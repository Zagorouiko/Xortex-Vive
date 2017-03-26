using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    private SteamVR_TrackedObject controller;

    void Update()
    {
        if (controller != null)
        {
            transform.position = controller.transform.position;
            transform.rotation = controller.transform.rotation;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        ControllerCollider collider = other.GetComponent<ControllerCollider>();
        if (collider != null)
        {
            controller = collider.controller;
        }
    }
}
