using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour {

	// Use this for initialization
	public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    // Update is called once per frame
    public void quit()
    {
        Application.Quit();
    }
}
