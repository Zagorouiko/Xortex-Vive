using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public ParticleSystem laser;
    private SteamVR_TrackedObject controller;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward))
        {
            SteamVR_LaserPointer.Emit(1);
        }
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
