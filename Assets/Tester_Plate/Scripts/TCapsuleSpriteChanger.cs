using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.11.5
/// </summary>

public class TCapsuleSpriteChanger : MonoBehaviour
{
    [SerializeField]
    Vector2 bounce = new Vector2(0,10f);

    [SerializeField]
    int hits = 20;

    [SerializeField]
    Sprite[] sprites;

    int count = 0;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       // spriteRenderer.sprite = sprites[0];
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag == "Ground")
        {
            count++;
            hits--;
            Bounce();
            SpriteChanger();
            print(count);
        }
    }

    void Bounce()
    {
        rb.velocity = new Vector2(0,1);
    }

    void SpriteChanger()
    {
        if(hits < 15)
        {
            spriteRenderer.sprite = sprites[0];
        }
        else if(hits < 10)
        {
            spriteRenderer.sprite = sprites[1];
        }
    }
}
