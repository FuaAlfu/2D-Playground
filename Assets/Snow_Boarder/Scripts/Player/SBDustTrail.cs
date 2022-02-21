using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.21
/// </summary>

public class SBDustTrail : MonoBehaviour
{
    [SerializeField]
    ParticleSystem _particleSystem;

    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.CompareTag("terrine"))
        {
            _particleSystem.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("terrine"))
        {
            _particleSystem.Stop();
        }
    }
}
