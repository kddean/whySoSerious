using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight: MonoBehaviour {

    Material material;
    private Color normalColor;
    private Color highlightColor;
    private bool touching;
    private float interval;

	void Start()
    {
        material = GetComponent<MeshRenderer>().material;

        normalColor = material.color;

        highlightColor = new Color
        (
            normalColor.r * 1.5f,
            normalColor.g * 1.5f,
            normalColor.b * 1.5f
        );
    }

    void Update()
    {
        if (touching)
        {
            interval += Time.deltaTime;
            material.color = Color.Lerp(normalColor, highlightColor, interval);
        }
        else
        {
            material.color = normalColor;
        }
    }

    void OnMouseOver()
    {
        touching = true;
    }

    void OnMouseExit()
    {
        touching = false;
        interval = 0f;
    }

   
}
