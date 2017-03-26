using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCollider : MonoBehaviour
{

    public SteamVR_TrackedObject controller;
	
	// Update is called once per frame
	void Update () {
	    if (controller != null)
	    {
	        transform.position = controller.transform.position;
	        transform.rotation = controller.transform.rotation;
	    }
	}
}
