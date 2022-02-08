using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 2022.2.8
/// </summary>

public class CartScoreRecored : MonoBehaviour
{
    [SerializeField]
    private int addPointForTest;

    [SerializeField]
    Text addForTest;

    private void Start()
    {
        addForTest.text = addPointForTest.ToString();
    }

    public void ScoreTracking(int add)
    {
        addPointForTest += add;
        addForTest.text = addPointForTest.ToString();
    }
}
