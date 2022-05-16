using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.5.16
/// </summary>

public class SESpawn : MonoBehaviour
{
    /*
     Transform[] border
    border[0] = left
    border[1] = right
    border[2] = bottom
    border[3] = top
     */
    // Food Prefab
    public GameObject foodPrefab;

    // Borders
    [SerializeField]
    Transform[] borders;

    public Transform borderTop;
    public Transform borderBottom;
    public Transform borderLeft;
    public Transform borderRight;

    // Use this for initialization
    void Start()
    {
        // Spawn food every 4 seconds, starting in 3
        InvokeRepeating("Spawn", 3, 4);
    }

    // Spawn one piece of food
    void Spawn()
    {
        //x position between left &right border
        int x = (int)Random.Range(borderLeft.position.x,
                                  borderRight.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(borderBottom.position.y,
                                  borderTop.position.y);



        // Instantiate the food at (x, y)
        Instantiate(foodPrefab,
                    new Vector2(x, y),
                    Quaternion.identity); // default rotation
    }
}
