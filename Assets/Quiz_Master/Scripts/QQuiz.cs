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
    [Header("Questions")]
    //[SerializeField]
    //QQuestionsSO currentQuestion;

    [SerializeField]
    List<QQuestionsSO> questions = new List<QQuestionsSO>();
    QQuestionsSO currentQuestion;

    [SerializeField]
    TextMeshProUGUI questionText;

    [Header("Answers")]
    [SerializeField]
    GameObject[] answerButtons;

    [SerializeField]
    Sprite defaultAnsweSprite;

    [Header("Button Colors")]
    [SerializeField]
    Sprite correctAnsweSprite;

    [Header("Timer")]
    [SerializeField]
    Image timerImage;

    QQTimer timer;

    int correctAnswerIndex;
    bool hasAnsweredEarly;

    // Start is called before the first frame update
    void Start()
    {
        timer = FindObjectOfType<QQTimer>();

        // GetNextQuestion();
        // DisplayQuestion();

        /* for testing, return the first element..s
            TextMeshProUGUI buttonTxt = answerButtons[0].GetComponentInChildren<TextMeshProUGUI>();
            buttonTxt.questionText = currentQuestion.GetAnswer(0);
         */
    }

    // Update is called once per frame
    void Update()
    {
        timerImage.fillAmount = timer.GetFullFraction();
        if(timer.loadNextQuestion)
        {
            hasAnsweredEarly = false;
            GetNextQuestion();
            timer.loadNextQuestion = false;
        }
        else if(!hasAnsweredEarly && !timer.isAnsweringQuestion)
        {
            DisplayAnswer(-1);
            SetButtonState(false);
        }
    }

    public void OnAnswerSelected(int index)
    {
        hasAnsweredEarly = true;
        DisplayAnswer(index);
        SetButtonState(false);
        
        timer.CancelTimer();
    }

    void GetRandomQuestion()
    {
        int index = UnityEngine.Random.Range(0, questions.Count);
        currentQuestion = questions[index];
        if(questions.Contains(currentQuestion))
        {
            questions.Remove(currentQuestion);
        }
    }

    void DisplayAnswer(int index)
    {
        Image buttonImage;

        if (index == currentQuestion.GetCorrectAnswerIndex())
        {
            questionText.text = "Correct";
            buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = correctAnsweSprite;
        }
        else
        {
            correctAnswerIndex = currentQuestion.GetCorrectAnswerIndex();
            string correctAnswer = currentQuestion.GetAnswer(correctAnswerIndex);
            questionText.text = "the correct answer was:\n" + correctAnswer;

            buttonImage = answerButtons[correctAnswerIndex].GetComponent<Image>();
            buttonImage.sprite = correctAnsweSprite;
        }
    }

    private void GetNextQuestion()
    {
        if(questions.Count > 0)
        {
            SetButtonState(true);
            SetDefaultButtonSprite();
            GetRandomQuestion();
            DisplayQuestion();
        }
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
        questionText.text = currentQuestion.GetQuestion();

        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonTxt = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonTxt.text = currentQuestion.GetAnswer(i);
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
