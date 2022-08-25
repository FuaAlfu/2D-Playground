using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// 2022.5.25
/// </summary>

public class GameSession : MonoBehaviour
{
    public static GameSession Instance;

    [field: SerializeField]
    TextMeshProUGUI text;

    private int score;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        text.text = score.ToString();
    }

    public void ScoreToAdd(int s)
    {
        score += s;
        text.text = score.ToString();
    }
}
