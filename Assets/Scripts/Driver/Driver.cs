using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.1.27
/// </summary>

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 0.1f); //rotate
        transform.Translate(0, 0.01f, 0);
    }
}
