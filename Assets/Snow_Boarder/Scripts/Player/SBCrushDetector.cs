using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.14
/// </summary>

public class SBCrushDetector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("terrine"))
        {
            print("HIT...");
        }
    }
}
