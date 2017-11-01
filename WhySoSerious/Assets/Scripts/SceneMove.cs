using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneMove : MonoBehaviour {

    string sceneName;
    string sceneChange;
	// Use this for initialization
	void Start () {
        sceneName = SceneManager.GetActiveScene().name;
	}
	
	// Update is called once per frame
	void Update () {
		
       
	}

    public void LoadScreen(string scene)
    {
        if (sceneName == "Main")
        {
            sceneChange = "Bathroom";
            SceneManager.LoadScene(sceneChange, LoadSceneMode.Single);
        }
        else
        {
            sceneChange = "Main";
            SceneManager.LoadScene(sceneChange, LoadSceneMode.Single);
        }
        
    }
}
