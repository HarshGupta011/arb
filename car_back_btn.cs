using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class car_back_btn : MonoBehaviour, IVirtualButtonEventHandler
{

    // Use this for initialization
    void Start()
    {
        VirtualButtonBehaviour vrb = GetComponentInChildren<VirtualButtonBehaviour>();
        vrb.RegisterEventHandler(this);
        Debug.Log("Button Pressed");

    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed virt");
        SceneManager.LoadSceneAsync(1);
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
