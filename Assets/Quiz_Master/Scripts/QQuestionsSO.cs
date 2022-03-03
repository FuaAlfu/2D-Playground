using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.3.3
/// </summary>

[CreateAssetMenu(menuName ="Quiz Question",fileName = "New Question")]
public class QQuestionsSO : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField]
    string question = "Enter new question text here";

    [SerializeField]
    string[] answers = new string[4];

    [SerializeField]
    int correctAnswerIndex; 

    public string GetQuestion()
    {
        return question;
    }

    public int CorrectAnserIndex()
    {
        return correctAnswerIndex;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }
}
