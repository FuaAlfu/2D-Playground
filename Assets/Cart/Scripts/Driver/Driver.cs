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
    private float steerSpeed, moveSpeed,slowSpeed,boostSpeed;

    // Start is called before the first frame update
    void Start()
    {
        steerSpeed = 300f;  //1
        moveSpeed = 20f;   //0.01f;
        slowSpeed = 15f;
        boostSpeed = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount); //rotate
        transform.Translate(0, moveAmount, 0);
    }

    public float BoostSpeed()
    {
        return moveSpeed = boostSpeed;
    }

    public float SlowSpeed()
    {
        return moveSpeed = slowSpeed;
    }
}
