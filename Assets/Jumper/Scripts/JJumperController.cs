using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.11.25
/// </summary>

public class JJumperController : MonoBehaviour
{
    [SerializeField]
    float speed = 2.8f;

    [SerializeField]
    float jumpForce = 10.21f;

    [SerializeField]
    float jumpTime;

    [SerializeField]
    float jumpStartTime;

    [SerializeField]
    Transform feetPos;

    [SerializeField]
    float checkRadius;

    [SerializeField]
    LayerMask theGround;

    private Rigidbody2D rb;
    private float moveInput;
    private bool isGrounded;
    private bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        ForceMoveDirection();
        jump();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    private void jump()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, theGround);
        if (isGrounded == true && Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            jumpTime = jumpStartTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetButton("Jump") && isJumping == true)
        {
            if (jumpTime > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTime -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

        if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
        }
    }

    private void ForceMoveDirection()
    {
        
    }
}
