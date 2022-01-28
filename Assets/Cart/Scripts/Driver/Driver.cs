using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.1.27
/// </summary>

public class Driver : MonoBehaviour
{
    [Header("props")]
    [Tooltip("steer")]
    [SerializeField]
    private float steerSpeed = 0.01f;

    [SerializeField]
    private float moveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, steerSpeed); //rotate
        transform.Translate(0, moveSpeed, 0);
    }
}
