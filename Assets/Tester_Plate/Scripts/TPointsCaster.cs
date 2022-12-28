using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPointsCaster : MonoBehaviour
{
    [SerializeField]
    private float distance = 1.2f;


    private int counter = 0;

    private void FixedUpdate()
    {
        PlayerDetected();
    }

    private void PlayerDetected()
    {
        // var ray = transform.position;

        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, Vector2.up, distance);
        Debug.DrawRay(this.transform.position, Vector2.up * distance, Color.red);

        if (hit.collider.name != "name")
        {
            var selection = hit.transform;

            if (selection.CompareTag("Player"))
            {
                counter++;
                print("hitsToShowOnBoard count:" + counter);
            }
        }
    }
}
