using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class players : MonoBehaviour
{
    public double velocidade; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, Input.GetAxis("Vertical") * Time.deltaTime, 0);
        
    }
}
