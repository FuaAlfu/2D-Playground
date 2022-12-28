using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.12.14
/// </summary>

public class TSquare : MonoBehaviour
{

    public enum SqureType
    {
        YELLOW,
        RED,
        Blue,
        Black
    }

    [SerializeField]
    TPointsSO tp;

    public bool yellow, red, blue, black;
    private void Start()
    {
        //destroy
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (yellow == true)
            {
                TGamesSession.Instance.PlusHitCounter(tp.PointsToAddForTable());
            }

            if (red == true)
            {
                TGamesSession.Instance.SubstractHitCounter(tp.PointsToAddForTable());
            }
            Destroy(this.gameObject);
        }
    }

    //for testing..
    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
