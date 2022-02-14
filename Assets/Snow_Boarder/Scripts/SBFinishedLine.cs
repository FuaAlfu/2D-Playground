using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.14
/// </summary>

public class SBFinishedLine : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.CompareTag("Player"))
        {
            print("finished...");
        }
    }
}
