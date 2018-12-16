using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;
using UnityEngine.XR;

public class building_back_btn : MonoBehaviour, IVirtualButtonEventHandler
{

    // Use this for initialization
    public void Start()
    {
        VirtualButtonBehaviour vrb = GetComponentInChildren<VirtualButtonBehaviour>();
        vrb.RegisterEventHandler(this);
        Debug.Log("sdfsfsdfs");
        //StartCoroutine(ActivatorVR("cardboard"));

    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        StartCoroutine(SwitchToVR());
    }

    public IEnumerator SwitchToVR()
    {
  
        XRSettings.LoadDeviceByName("cardboard");

        // Must wait one frame after calling `XRSettings.LoadDeviceByName()`.
        yield return null;

        // Now it's ok to enable VR mode.
        XRSettings.enabled = true;
        SceneManager.LoadScene(2);
    }





    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
