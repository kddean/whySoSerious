using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keybroad : MonoBehaviour {

    float moveSpeed = 5.0f;
    float rotateSpeed = 60f;


    // Use this for initialization
    void Start()
    {
       
    }




    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(new Vector3(0, -rotateSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(new Vector3(0, 0, moveSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(new Vector3(0, 0, -moveSpeed * Time.deltaTime));
        }
    }
}
