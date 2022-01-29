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
    private float steerSpeed = 1f;

    [SerializeField]
    private float moveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount); //rotate
        transform.Translate(0, moveAmount, 0);
    }
}
