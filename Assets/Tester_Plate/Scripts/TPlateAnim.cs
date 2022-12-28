using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.12.28
/// </summary>
public class TPlateAnim : MonoBehaviour
{

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Angry()
    {
        anim.SetBool("", true);
    }

    void Happy()
    {
        anim.SetBool("", true);
    }
}
