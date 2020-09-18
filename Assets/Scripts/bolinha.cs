using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolinha : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        x = UnityEngine.Random.Range(6f, -6f); 
        y = UnityEngine.Random.Range(6f, -6f);
        /* Necessário adicionar "UnityEngine." */
           
        rb2D.velocity = new Vector2(x, y);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb2D.velocity.x < 2f && rb2D.velocity.x > -2f)
        {
            if (rb2D.velocity.x >= 0)
            {
                rb2D.velocity = new Vector2(2f, rb2D.velocity.y);
            } else
            {
                rb2D.velocity = new Vector2(-2f, rb2D.velocity.y);
            }
            
        }

        if (rb2D.velocity.y < 2f && rb2D.velocity.y > -2f)
        {
            if (rb2D.velocity.y >= 0)
            {
                rb2D.velocity = new Vector2(rb2D.velocity.x, 2f);
            } else
            {
                rb2D.velocity = new Vector2(rb2D.velocity.x, -2f);
            }
            
        }
    }
}
