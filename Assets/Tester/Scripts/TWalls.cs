using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.9.12
/// </summary>

public class TWalls : MonoBehaviour
{
    private Vector3 target;

    [SerializeField]
    float x, y;
    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.GetComponent<TMover>())
        {
            //c.gameObject.transform.position = new Vector3(x, y, 0) * Time.deltaTime;
            //target = transform.position + new Vector3(x, y, 0);
            c.gameObject.transform.position = new Vector2(x, y);
            FindObjectOfType<TPointsBorder>().pointsCounter();
            print("cross");
        }
    }
}
