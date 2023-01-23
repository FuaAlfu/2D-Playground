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

    public bool testLose;
    public bool testWint;
    public bool testGame;

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
        if(testGame == true)
        {
            Spawning();
        }
        else if(testLose == true)
        {
            LoseTestGame();
        }
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

    private void LoseTestGame()
    {
        int randomSpawns = UnityEngine.Random.Range(0, spoints.Length);
        int randomPorts = UnityEngine.Random.Range(0, objectsToSpawns.Length);

        if (timeBetweenSpawns <= 0)
        {
            Instantiate(objectsToSpawns[0], spoints[randomSpawns].position, spoints[randomSpawns].rotation);
            timeBetweenSpawns = timeRset;
        }
        else
        {
            timeBetweenSpawns -= Time.deltaTime;
        }
    }
}
