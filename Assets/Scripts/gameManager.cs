using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

    public int pontuacao1, pontuacao2;
    public Text pontosPlayer1, pontosPlayer2;

    // Start is called before the first frame update
    void Start()
    {
        pontuacao1 = 0;
        pontuacao2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pontosPlayer1.text = pontuacao1.ToString();
        pontosPlayer2.text = pontuacao2.ToString();
    }
}
