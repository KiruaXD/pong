using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class Ball : MonoBehaviour
{
    public int MaxSpeed ;
    public int updateRate;
    public float speed;
    public Rigidbody2D rb;
    private Vector2 startPosition;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        Launch();
    }

    private void Launch()
    {

        float x = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        float y = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(x * speed, y * speed);
    }

    // Update is called once per frame
    void Update()
    {

    }

 

    public void Reset()
    {
        updateRate = 0;
        transform.position = startPosition;
        rb.velocity = Vector2.zero;
        Launch();
    }
}
