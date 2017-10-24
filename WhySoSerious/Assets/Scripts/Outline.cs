using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outline : MonoBehaviour {

    Material material;
    private Color normalColor;
    private Color highlightColor;
    private bool touching;
    private float interval;

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
    }
	
	// Update is called once per frame
	void Update () {
        if (touching)
        {
            interval += Time.deltaTime;
            material.shader = Shader.Find("Outlined/Silhouetted Diffuse");
        }
        else
        {
            material.shader = Shader.Find("Diffuse");
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
