using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class bolinha : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float x, y;
    public bool jogo;
    private gameManager gManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        gManagerScript = GameObject.Find("GameManager").GetComponent<gameManager>();

        x = UnityEngine.Random.Range(-6f, 6f);
        y = UnityEngine.Random.Range(-6f, 6f);
        /* Necessário adicionar "UnityEngine." */

        rb2D.velocity = new Vector2(x, y);
        jogo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (jogo)
        {
            if (rb2D.velocity.x < 2f && rb2D.velocity.x > -2f)
            {
                if (rb2D.velocity.x >= 0)
                {
                    rb2D.velocity = new Vector2(2f, rb2D.velocity.y);
                }
                else
                {
                    rb2D.velocity = new Vector2(-2f, rb2D.velocity.y);
                }

            }

            if (rb2D.velocity.y < 2f && rb2D.velocity.y > -2f)
            {
                if (rb2D.velocity.y >= 0)
                {
                    rb2D.velocity = new Vector2(rb2D.velocity.x, 2f);
                }
                else
                {
                    rb2D.velocity = new Vector2(rb2D.velocity.x, -2f);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && jogo == false)
        {
            Start();
        }
    }

    void OnTriggerEnter2D(Collider2D oth)
    {
        if (oth.gameObject.tag == "paredeDireita")
        {
            rb2D.velocity = Vector2.zero; //.zero = (0, 0)
            transform.position = new Vector3(0, 0, 0);
            jogo = false;
            gManagerScript.pontuacao2++;

        }
        if (oth.gameObject.tag == "paredeEsquerda")
        {
            rb2D.velocity = Vector2.zero;
            transform.position = new Vector3(0, 0, 0);
            jogo = false;
            gManagerScript.pontuacao1++;
        }
    }
}
