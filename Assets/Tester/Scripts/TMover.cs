using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.9.12
/// </summary>

public class TMover : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1.6f;

    [Header("Directions")]
    public bool up;
    public bool down;
    public bool right;
    public bool left;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(up == true)
        {
            this.transform.Translate(Vector2.up * _speed * Time.deltaTime);
        }

        if (right == true)
        {
            this.transform.Translate(Vector2.right * _speed * Time.deltaTime);
        }
    }
}
