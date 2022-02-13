using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.13
/// </summary>

[RequireComponent(typeof(Rigidbody2D))]
public class SBPlayerController : MonoBehaviour
{
    [SerializeField]
    private float totqueAmount = 1f;

    Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb2D.AddTorque(totqueAmount);
        }
       else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2D.AddTorque(-totqueAmount);
        }
    }
}
