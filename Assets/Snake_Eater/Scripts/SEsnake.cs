using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// 2022.5.23
/// </summary>

public class SEsnake : MonoBehaviour
{
    // Tail Prefab
    [SerializeField]
     GameObject tailPrefab;

    [SerializeField]
    ScoreQ scoreQ;

    [SerializeField]
    float speed = 2f;

    Vector2 dir = Vector2.right;
    List<Transform> tail = new List<Transform>();

    bool ate = false;

    // Use this for initialization
    void Start()
    {
        // Move the Snake every 300ms
        InvokeRepeating("Move", 0.3f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        Controller();
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        // Food?
        if (c.name.StartsWith("Food") || c.gameObject.CompareTag("target"))
        {
            // Get longer in next Move call
            ate = true;

            //add score
            GameSession.Instance.ScoreToAdd(scoreQ.GetScore());

            //test
            print("yum");

            // Remove the Food
            Destroy(c.gameObject);
        }
        // Collided with Tail or Border
        else
        {
            // ToDo 'You lose' screen
        }
    }

    void Move()
    {
        this.transform.Translate(dir * speed * Time.deltaTime);
        Vector2 v = transform.position;

        if (ate)
        {
            // Load Prefab into the world
            GameObject g = (GameObject)Instantiate(tailPrefab, v, Quaternion.identity);
            // Keep track of it in our tail list
            tail.Insert(0, g.transform);

            // Reset the flag
            ate = false;
        }

        // Tail
        else if (tail.Count > 0)
        {
            // Move last Tail Element to where the Head was
            tail.Last().position = v;

            // Add to front of list, remove from the back
            tail.Insert(0, tail.Last());
            tail.RemoveAt(tail.Count - 1);
        }
    }

    void Controller()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            dir = Vector2.right;
        else if (Input.GetKey(KeyCode.DownArrow))
            dir = -Vector2.up;    // '-up' == 'down'
        else if (Input.GetKey(KeyCode.LeftArrow))
            dir = -Vector2.right; // '-right' == 'left'
        else if (Input.GetKey(KeyCode.UpArrow))
            dir = Vector2.up;
    }
}
