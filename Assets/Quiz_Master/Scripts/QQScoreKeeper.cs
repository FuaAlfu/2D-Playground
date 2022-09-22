using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.9.22
/// 
/// for good practice use properties
/// </summary>

public class QQScoreKeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionsSeen = 0;

    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }

    public void SetCorrectAnswers()
    {
        //increment correct answers + 1
        correctAnswers++;
    }

    public int GetQuestionsSeen()
    {
        return questionsSeen;
    }

    public void SetQuestionsSeen()
    {
        //increment questions seen + 1
        questionsSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(correctAnswers / (float)questionsSeen * 100);
    }
}
