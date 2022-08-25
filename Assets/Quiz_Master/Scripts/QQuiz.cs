using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

/// <summary>
/// 2022.3.8
/// </summary>

public class QQuiz : MonoBehaviour
{
    [SerializeField]
    QQuestionsSO qQuestions;

    [SerializeField]
    TextMeshProUGUI questionText;

    [SerializeField]
    GameObject[] answerButtons;

    [SerializeField]
    Sprite defaultAnsweSprite;

    [SerializeField]
    Sprite correctAnsweSprite;

    int correctAnswerIndex;

    // Start is called before the first frame update
    void Start()
    {
        GetNextQuestion();
       // DisplayQuestion();

        /* for testing, return the first element..s
            TextMeshProUGUI buttonTxt = answerButtons[0].GetComponentInChildren<TextMeshProUGUI>();
            buttonTxt.questionText = qQuestions.GetAnswer(0);
         */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAnswerSelected(int index)
    {
        Image buttonImage;

        if (index == qQuestions.GetCorrectAnswerIndex())
        {
            questionText.text = "Correct";
            buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = correctAnsweSprite;
        }
        else
        {
            correctAnswerIndex = qQuestions.GetCorrectAnswerIndex();
            string correctAnswer = qQuestions.GetAnswer(correctAnswerIndex);
            questionText.text = "the correct answer was:\n" + correctAnswer;

            buttonImage = answerButtons[correctAnswerIndex].GetComponent<Image>();
            buttonImage.sprite = correctAnsweSprite;
        }
        SetButtonState(false);
    }

    private void GetNextQuestion()
    {
        SetButtonState(true);
        SetDefaultButtonSprite();
        DisplayQuestion();
    }

    private void SetDefaultButtonSprite()
    {
       for(int i = 0; i < answerButtons.Length; i++)
        {
            Image buttonImage = answerButtons[i].GetComponent<Image>();
            buttonImage.sprite = defaultAnsweSprite;
        }
    }

    private void DisplayQuestion()
    {
        questionText.text = qQuestions.GetQuestion();

        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonTxt = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonTxt.text = qQuestions.GetAnswer(i);
        }
    }

    private void SetButtonState(bool state)
    {
        for(int i = 0; i < answerButtons.Length; i++)
        {
            Button button = answerButtons[i].GetComponent<Button>();
            button.interactable = state;
        }
    }
}
