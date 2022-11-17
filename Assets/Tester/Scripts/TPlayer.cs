using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.11.17
/// </summary>

public class TPlayer : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 4.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }

    private void Mover()
    {
       // float move = Input.GetAxis("Horizontal") * moveSpeed;
        float move = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(move, 0,0);
    }
}
