using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.11.17
/// </summary>
public class TSpawner : MonoBehaviour
{
    [SerializeField]
    Transform[] spoints;

    [SerializeField]
    GameObject[] objectsToSpawns;

    private float timeBetweenSpawns;
    private float timeRset;
    // Start is called before the first frame update
    void Start()
    {
        timeRset = 0.5f;
        timeBetweenSpawns = timeRset;
    }

    // Update is called once per frame
    void Update()
    {
        Spawning();
    }

    private void Spawning()
    {
        int randomSpawns = UnityEngine.Random.Range(0, spoints.Length);
        int randomPorts = UnityEngine.Random.Range(0, objectsToSpawns.Length);

        if(timeBetweenSpawns <= 0)
        {
            Instantiate(objectsToSpawns[randomPorts], spoints[randomSpawns].position, spoints[randomSpawns].rotation);
            timeBetweenSpawns = timeRset;
        }
        else
        {
            timeBetweenSpawns -= Time.deltaTime;
        }
    }
}
