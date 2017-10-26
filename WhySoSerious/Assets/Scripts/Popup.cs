using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour {

    public GameObject popup;
    public GameObject ui;
    public GameObject panel;
    public GameObject text;
    bool t;

	// Use this for initialization
	void Start () {
       /* ui = GameObject.FindGameObjectWithTag("UI");
        panel = GameObject.FindGameObjectWithTag("Panel");
        BedPopup = GameObject.FindGameObjectWithTag("Popup");
        */
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if (t == false)
        {
            t = true;
            ui.SetActive(true);
            //panel.SetActive(true);
            popup.SetActive(true);
            text.SetActive(true);
        }
        else
        {
            t = false;
            ui.SetActive(false);
            //panel.SetActive(false);
            popup.SetActive(false);
            text.SetActive(false);
        }

    }
}
