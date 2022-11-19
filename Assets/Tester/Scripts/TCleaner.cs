using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.11.18
/// </summary>

public class TCleaner : MonoBehaviour
{

    [SerializeField]
    float timer = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, timer);
    }
}
