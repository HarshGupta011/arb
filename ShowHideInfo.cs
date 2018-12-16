using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideInfo : MonoBehaviour {

	public GameObject InfoObject;
	private bool Show = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ShowAndHideInfo() {
		if(!Show){
			InfoObject.SetActive(true);
			Show=true;
		}
		else {
			InfoObject.SetActive(false);
			Show= false;
		}
	}
}
