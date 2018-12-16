﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PhoneCall : MonoBehaviour, IVirtualButtonEventHandler
{

    // Use this for initialization
    void Start()
    {
        VirtualButtonBehaviour vrb = GetComponentInChildren<VirtualButtonBehaviour>();
        vrb.RegisterEventHandler(this);

    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "phonevb")
        {
            //string email = "rajatmishra243@gmail.com";
            Debug.Log("Button Pressed");
            Application.OpenURL("tel://7014260426");
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
