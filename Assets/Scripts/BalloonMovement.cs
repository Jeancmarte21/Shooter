using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMovement : MonoBehaviour
{

    public float Velocidad = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.up * Velocidad * Time.deltaTime;

        //transform.position -= transform.up * Velocidad * Time.deltaTime;
        
    }
}
