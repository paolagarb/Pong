﻿using System;
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
        x = Random.Range(2f, -2); 
        y = Random.Range(2f, -2);
           
        rb2D.velocity = new Vector2(x, y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
