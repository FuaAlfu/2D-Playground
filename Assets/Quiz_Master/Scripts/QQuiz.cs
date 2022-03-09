using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// 2022.3.8
/// </summary>

public class QQuiz : MonoBehaviour
{
    [SerializeField]
    QQuestionsSO qQuestions;

    [SerializeField]
    TextMeshProUGUI text;

    [SerializeField]
    GameObject[] buttons;

    // Start is called before the first frame update
    void Start()
    {
        text.text = qQuestions.GetQuestion();

        for(int i = 0; i < buttons.Length; i++)
        {
            TextMeshProUGUI buttonTxt = buttons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonTxt.text = qQuestions.GetAnswer(i);
        }

        /* for testing
            TextMeshProUGUI buttonTxt = buttons[0].GetComponentInChildren<TextMeshProUGUI>();
            buttonTxt.text = qQuestions.GetAnswer(0);
         */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
