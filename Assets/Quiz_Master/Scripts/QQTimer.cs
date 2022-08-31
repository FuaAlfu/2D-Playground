using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.8.31
/// </summary>

public class QQTimer : MonoBehaviour
{
    [SerializeField]
    private float timeToCompleteQuestion = 20f;

    [SerializeField]
    private float timeToShowCorrectAnswer = 5f;

    public bool isAnsweringQuestion = false;

    private float timerVal;

    void Update()
    {
        UpdateTimer();
    }

    private void UpdateTimer()
    {
        // timerVal = timerVal - Time.deltaTime;
        timerVal -= Time.deltaTime;

        if(isAnsweringQuestion)
        {
            if(timerVal <= 0)
            {
                isAnsweringQuestion = false;
                timerVal = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if(timerVal <= 0)
            {
                isAnsweringQuestion = true;
                timerVal = timeToCompleteQuestion;
            }
        }

     //for testing..
        //if(timerVal <= 0)
        //{
        //    timerVal = timeToCompleteQuestion;
        //}
        Debug.Log(timerVal);
    }
}
