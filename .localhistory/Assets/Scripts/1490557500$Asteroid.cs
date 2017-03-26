using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

    void Start()
    {
        Rigidbody r = GetComponent<Rigidbody>();
        r.velocity = Random.onUnitSphere*Random.Range(.5f, 1f);
        r.angularVelocity = Random.onUnitSphere*Random.Range(.3f, .7f);
    }
	// Use this for initialization
    void OnTriggerEnter()
    {
        Destroy(gameObject);
    }
}
