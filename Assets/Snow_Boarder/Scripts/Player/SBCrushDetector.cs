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

    [SerializeField]
    AudioClip cushClipSFX;

    private bool hasCrashed = false;

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.CompareTag("terrine") && !hasCrashed)
        {
            hasCrashed = true;
            DisableControls();
            print("HIT...");
            crushedVfX.Play();
            GetComponent<AudioSource>().PlayOneShot(cushClipSFX);
            Invoke("LoadScene", timer);
        }
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        //if (c.gameObject.CompareTag("terrine") && !hasCrashed)
        //{
        //    hasCrashed = true;
        //    DisableControls();
        //    print("HIT...");
        //    crushedVfX.Play();
        //    GetComponent<AudioSource>().PlayOneShot(cushClipSFX);
        //    //Invoke("LoadScene", timer);
        //}
    }

     void DisableControls()
    {
        GetComponent<SBPlayerController>().canMove = false;
        GetComponent<SBPlayerController>().baseSpeed = 0;
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(3);
    }
}
