using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 2022.4.16
/// </summary>

public class GamesLoader : MonoBehaviour
{
    [SerializeField]
    List<int> levels; 

    private void Start()
    {
        levels = new List<int>();
    }

    public void LevelSelector()
    {
        foreach (int index in levels)
        {
            SceneManager.LoadScene(levels[index]);
        }
    }

    public void GameOne()
    {
        SceneManager.LoadScene(2);
    }

    public void GameTwo()
    {
        SceneManager.LoadScene(3);
    }
}
