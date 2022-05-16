using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.13
/// </summary>

[RequireComponent(typeof(Rigidbody2D))]
public class SBPlayerController : MonoBehaviour
{
    [SerializeField]
    private float totqueAmount = 1f;

    [SerializeField]
    private float boostUp = 30f;

   
    public float baseSpeed = 20f;

    public bool canMove = true;

    Rigidbody2D rb2D;
    SurfaceEffector2D SurfaceEffector2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        SurfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {
            RotatePlayerController();
            RespondToBoost();
         }
    }

    private void RespondToBoost()
    {
      
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
        {
            SurfaceEffector2D.speed = boostUp;
        }
        else
        {
            SurfaceEffector2D.speed = baseSpeed;
        }
    }

    private void RotatePlayerController()
    {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb2D.AddTorque(totqueAmount);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                rb2D.AddTorque(-totqueAmount);
            }
    }
}
