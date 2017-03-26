using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{

    public GameObject[] asteroidPrefabs;
	// Use this for initialization
	void Start ()
	{
	    StartCoroutine(SpawnAsteroids());
	}
	
	// Update is called once per frame
    IEnumerator SpawnAsteroids()
    {
        while (true)
        {
            Instantiate(asteroidPrefabs[Random.Range(0, asteroidPrefabs.Length)], Random.onUnitSphere * Random.Range(.7f, 2f),
                Quaternion.identity);
            Debug.Log(Random.onUnitSphere);
            yield return new WaitForSeconds(Random.Range(0.3f, 1f));
        }
    }
}
