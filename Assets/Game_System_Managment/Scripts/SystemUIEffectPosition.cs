using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.4.16
/// </summary>

public class SystemUIEffectPosition : MonoBehaviour
{
    [SerializeField]
    GameObject pos;

    public bool left, right;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (right == true)
        {
            Vector2 dir = Vector2.right * 1000 * Time.deltaTime;
            transform.Translate(dir);
            if (transform.position.x >= (3000))
            {
                transform.position = pos.transform.position;
            }
        }
        else if (left == true)
        {
            Vector2 dir = Vector2.left * 1000 * Time.deltaTime;
            transform.Translate(dir);
            if (transform.position.x <= (-1300))
            {
                transform.position = pos.transform.position;
            }
        }
    }
}
