using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.11.18
/// </summary>
public class TGoal : MonoBehaviour
{
    private int count = 1;
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.GetComponent<TBallBounce>())
        {
           // TGamesSession.Instance.PlusHitCounter(count);
        }

        //if (c.gameObject.GetComponent<TPlayer>())
        //{
        //   TGamesSession.Instance.PlusHitCounter(count);
        //}
    }
}
