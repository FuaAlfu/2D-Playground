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
    private float timeToCompleteQuestion = 10f;

    [SerializeField]
    private float timeToShowCorrectAnswer = 5f;

    [SerializeField]
    float fillFraction;

    public bool loadNextQuestion;
    public bool isAnsweringQuestion = false;

    private float timerVal;

    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerVal = 0;
    }

    private void UpdateTimer()
    {
        // timerVal = timerVal - Time.deltaTime;
        timerVal -= Time.deltaTime;

        if(isAnsweringQuestion)
        {
            if(timerVal > 0)
            {
                fillFraction = timerVal / timeToCompleteQuestion; // 5/10 = 0.5
            }
            else 
            {
                isAnsweringQuestion = false;
                timerVal = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if(timerVal > 0)
            {
                fillFraction = timerVal / timeToShowCorrectAnswer;
            }
            else
            {
                isAnsweringQuestion = true;
                timerVal = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }

        //old -- still working
        /*
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
         */

        //for testing..
        //if(timerVal <= 0)
        //{
        //    timerVal = timeToCompleteQuestion;
        //}
        //Debug.Log(timerVal);
        Debug.Log(isAnsweringQuestion + ": " + timerVal + " = " + fillFraction);
    }

    public float GetFullFraction()
    {
        return fillFraction;
    }
}
