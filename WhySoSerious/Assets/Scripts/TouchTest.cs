using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Touch myTouch = Input.GetTouch(0);

        Touch[] myTouches = Input.touches;
        for (int i = 0; i < Input.touchCount; i++)
        {
            if (myTouch.phase == TouchPhase.Stationary || myTouch.phase == TouchPhase.Moved)
            {
                // If the finger is on the screen, move the object smoothly to the touch position
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(myTouch.position.x, myTouch.position.y, 10));
                transform.rotation = Quaternion.LookRotation(touchPosition);
                transform.position = Vector3.Lerp(transform.position, touchPosition, Time.deltaTime);
            }
    }
}
}
