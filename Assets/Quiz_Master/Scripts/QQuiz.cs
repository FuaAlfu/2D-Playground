using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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
    GameObject[] buttons;

    [SerializeField]
    Sprite defaultAnsweSprite;

    [SerializeField]
    Sprite correctAnsweSprite;

    int correctAnswerIndex;

    // Start is called before the first frame update
    void Start()
    {
        questionText.text = qQuestions.GetQuestion();

        for(int i = 0; i < buttons.Length; i++)
        {
            TextMeshProUGUI buttonTxt = buttons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonTxt.text = qQuestions.GetAnswer(i);
        }

        /* for testing, return the first element..s
            TextMeshProUGUI buttonTxt = buttons[0].GetComponentInChildren<TextMeshProUGUI>();
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
            buttonImage = buttons[index].GetComponent<Image>();
            buttonImage.sprite = correctAnsweSprite;
        }
        else
        {
            correctAnswerIndex = qQuestions.GetCorrectAnswerIndex();
            string correctAnswer = qQuestions.GetAnswer(correctAnswerIndex);
            questionText.text = "the correct answer was:\n" + correctAnswer;

            buttonImage = buttons[correctAnswerIndex].GetComponent<Image>();
            buttonImage.sprite = correctAnsweSprite;
        }
    }
}
