using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHighlight : MonoBehaviour {

    Material material;
    private Color normalColor;
    private Color highlightColor;
    private bool touching;
    private float interval;
    private bool once;
    private bool twice;
    public GameObject ui;

    // Use this for initialization
    void Start () {
        material = GetComponent<MeshRenderer>().material;

        normalColor = material.color;

        highlightColor = new Color
        (
            normalColor.r * 1.5f,
            normalColor.g * 1.5f,
            normalColor.b * 1.5f
        );

        once = false;
        twice = false;
    }
	
	// Update is called once per frame
	void Update () {
        touchHightlight();
    }

    void touchHightlight()
    {
        Touch myTouch = Input.GetTouch(0);

        if(myTouch.tapCount == 1)
        {
            once = true;
            interval += Time.deltaTime;
            material.color = Color.Lerp(normalColor, highlightColor, interval);
        }
        else
        {
            material.color = normalColor;
        }

        if(myTouch.tapCount == 2)
        {
            once = true;
            twice = true;
            interval += Time.deltaTime;
            material.color = Color.Lerp(normalColor, highlightColor, interval);
            ui.SetActive(true);
        }

        if(myTouch.tapCount == 1 && once == true && twice == true)
        {
            ui.SetActive(false);
            material.color = normalColor;
        }
        
    }
}
