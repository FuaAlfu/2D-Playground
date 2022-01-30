using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D c)
    {
        print("touch");
        //if (c.gameObject.CompareTag(""))
        //{
        //    print("touch");
        //}
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        print("entered");
    }
}
