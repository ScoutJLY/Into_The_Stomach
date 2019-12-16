using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Vector3 player;
    public GameObject bad;
    public GameObject good;
    public float spawnRate = 3f;
    private float lastSpawn = 0f;
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.time > spawnRate + lastSpawn)
        {
            Instantiate(bad, new Vector3(Random.Range(-20.0f, 20.0f), Random.Range(0, 20.0f), Random.Range(-20.0f, 20.0f)), Quaternion.identity);
            Instantiate(good, new Vector3(Random.Range(-20.0f, 20.0f), Random.Range(0, 20.0f), Random.Range(-20.0f, 20.0f)), Quaternion.LookRotation(player));
            lastSpawn = Time.time;
        }
    }
}
