using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DriverCollision : MonoBehaviour
{
    [SerializeField]
    private Color32 hasPackageColour = new Color32(1,1,1,1);

    [SerializeField]
    private Color32 noPackageColour = new Color32(1, 1, 1, 1);

    [SerializeField]
    private int scoreToAdd = 5;

    private bool hasPackage;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

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
            spriteRenderer.color = hasPackageColour;
            Destroy(c.gameObject);
        }

        if(c.gameObject.GetComponent<CartCustomer>() && hasPackage)
        {
            print("reached");
            FindObjectOfType<CartScoreRecored>().ScoreTracking(scoreToAdd);
            spriteRenderer.color = noPackageColour;
            hasPackage = false;
        }
    }
}
