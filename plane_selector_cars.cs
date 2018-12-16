using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class plane_selector_cars : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject aboutgo, projectsgo, modelgo;
    // Use this for initialization
    void Start()
    {
        VirtualButtonBehaviour[] vrb = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vrb.Length; i++)
        {
            vrb[i].RegisterEventHandler(this);
        }
        modelgo.SetActive(true);
        aboutgo.SetActive(false);
        projectsgo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "aboutvb")
        {
            Debug.Log("About Button pressed");
            modelgo.SetActive(false);
            aboutgo.SetActive(true);
            projectsgo.SetActive(false);
        }

        else if (vb.VirtualButtonName == "projectsvb")
        {
            Debug.Log("Projects Button pressed");
            modelgo.SetActive(false);
            aboutgo.SetActive(false);
            projectsgo.SetActive(true);
        }

        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual Button not supported");
        }

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Virtual Button Released");
    }
}
