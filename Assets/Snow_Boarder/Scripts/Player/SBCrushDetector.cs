using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 2022.2.14
/// </summary>

public class SBCrushDetector : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem crushedVfX;

    [SerializeField]
    private float timer = .5f;
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("terrine"))
        {
            print("HIT...");
            crushedVfX.Play();
            //Invoke("LoadScene", timer);
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
