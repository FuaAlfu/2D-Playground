using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.11.17
/// </summary>

public class TBallBounce : MonoBehaviour
{
    [SerializeField]
    Vector2 bounce = new Vector2(0,2.1f);
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.CompareTag("Ground"))
        {
            StartCoroutine(Bouncing());
        }
    }

    IEnumerator Bouncing()
    {
        Vector2 initialBounce = new Vector2(0, 4f);
        rb.velocity = initialBounce;
        yield return new WaitForSeconds(0.1f);
        BallBounce();
    }

    private void BallBounce()
    {
        rb.velocity = bounce;
        Destroy(this.gameObject, 1.2f);
    }
}
