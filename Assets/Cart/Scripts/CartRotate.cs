using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.8
/// </summary>

public class CartRotate : MonoBehaviour
{
    [SerializeField]
    private float rotate = 30f;


    private GameObject player;
    private bool isContact;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }

    void Rotation()
    {
        transform.Rotate(Vector3.back * rotate * Time.deltaTime);

        if (isContact == true)
        {
            player.transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
