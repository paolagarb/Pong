using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class players : MonoBehaviour
{
    public float velocidade;
    public GameObject player1, player2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player1.transform.position += new Vector3(0, Input.GetAxis("vPlayer1") * velocidade * Time.deltaTime, 0);
        player2.transform.position += new Vector3(0, Input.GetAxis("vPlayer2") * velocidade * Time.deltaTime, 0);
    }
}
