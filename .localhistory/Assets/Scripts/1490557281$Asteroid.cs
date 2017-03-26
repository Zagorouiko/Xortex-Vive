using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

	// Use this for initialization
    void OnTriggerEnter()
    {
        Destroy(gameObject);
    }
}
