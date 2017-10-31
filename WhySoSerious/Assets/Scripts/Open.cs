using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Open : MonoBehaviour {

    bool open;
    Vector3 orign;
    GameObject[] boxes;
    private GameObject box;

    
    // Use this for initialization
    void Start () {
        open = false;
        orign = this.transform.position;
        boxes = GameObject.FindGameObjectsWithTag("BBox");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if( open == false)
        {
            open = true;
            this.transform.Translate(new Vector3((-0.13f), 0, 0));
            for( int i = 0; i <4; i++)
            {
                box = boxes[i];
                box.transform.Translate(new Vector3((-0.09f), 0, 0));
            }
        }
        else
        {
            open = false;
            this.transform.position = orign;
            for (int i = 0; i < 4; i++)
            {
                box = boxes[i];
                box.transform.Translate(new Vector3((0.09f), 0, 0));
            }
        }
    }
}
