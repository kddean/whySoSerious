using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClick : MonoBehaviour
{

    public Camera camera;
    public Transform player;
    public Vector3 moveToPosition;
    public float speed = 5;

    private Ray ray;
    private RaycastHit hit;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // myTouch = Input.GetTouch(0);

        //Touch[] myTouches = Input.touches;
       // for (int i = 0; i < Input.touchCount; i++)
       // {
            if (Input.GetMouseButtonDown(0))
            {
                // If the finger is on the screen, move the object smoothly to the touch position
                Vector3 touchPosition = (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = Vector3.MoveTowards(transform.position, touchPosition, Time.deltaTime);
            }
       // }
    }
}
