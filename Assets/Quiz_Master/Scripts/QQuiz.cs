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

    // Start is called before the first frame update
    void Start()
    {
        text.text = qQuestions.GetQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
