using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 2022.2.14
/// </summary>

public class SBFinishedLine : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem finidhedVfX;

    [SerializeField]
    private float timer = 1.5f;

    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.CompareTag("Player"))
        {
            print("finished...");
            finidhedVfX.Play();
            GetComponent<AudioSource>().Play();
            //Invoke("LoadScene", timer);
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
