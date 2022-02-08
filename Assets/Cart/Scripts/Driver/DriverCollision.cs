using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DriverCollision : MonoBehaviour
{
    [SerializeField]
    private int scoreToAdd = 5;

    private bool hasPackage;

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
        if(c.gameObject.GetComponent<CartRotate>() && !hasPackage)
        {
            print("picked up");
            
            hasPackage = true;
            Destroy(c.gameObject);
        }

        if(c.gameObject.GetComponent<CartCustomer>() && hasPackage)
        {
            print("reached");
            FindObjectOfType<CartScoreRecored>().ScoreTracking(scoreToAdd);
            hasPackage = false;
        }
    }
}
