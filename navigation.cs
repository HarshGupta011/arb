using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class navigation : MonoBehaviour, IVirtualButtonEventHandler
{

    // Use this for initialization
    void Start()
    {
        VirtualButtonBehaviour vrb = GetComponentInChildren<VirtualButtonBehaviour>();
        vrb.RegisterEventHandler(this);

    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "navigationvb")
        {
            Debug.Log("Button Pressed");
            Application.OpenURL("https://www.google.co.in/maps/dir//forum+mall");
        }
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
