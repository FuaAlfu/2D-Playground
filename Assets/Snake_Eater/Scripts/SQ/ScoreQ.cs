using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "tools/score", fileName = "New Score")]
public class ScoreQ : ScriptableObject
{
    [SerializeField]
    int score;

    public int GetScore()
    {
        return score;
    }
}
