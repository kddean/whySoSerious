﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boundary
{
    public float xMin, xMax, zMin,zMax;
}


public class Player : MonoBehaviour {
    public float speed;
    public float tilt;
    private Rigidbody rb;
    public Boundary boundary;
    void Start()
    {
        
    }

    void Update()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveH, 0.0f, moveV);
        rb.velocity = movement * speed;

        rb.position = new Vector3(
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax), 0.0f, Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
            );

        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }
}
