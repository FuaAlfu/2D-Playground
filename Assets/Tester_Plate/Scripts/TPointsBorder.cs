using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TPointsBorder : MonoBehaviour
{
    [SerializeField]
    private float points;

    [SerializeField]
    Text pointTxt;

    [SerializeField]
    TPointsSO p;
    // Start is called before the first frame update
    void Start()
    {
        pointTxt.text = points.ToString();
    }

   public void pointsCounter()
    {
        points += p.PointToAdd();
        pointTxt.text = points.ToString();
    }
}
