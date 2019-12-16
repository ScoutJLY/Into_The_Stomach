using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;

    public GameObject pauseMenuUI;

    public void openpanel()
    {
        if (pauseMenuUI != null)
        {
            pauseMenuUI.SetActive(true);
           // Time.timeScale = 0f;


        }
    }
    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }


    void Update()
    {
        if (GameisPaused)
        {
            Resume();

        }
        else
        {
            //Pause();
        }

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
        //AudioListener.pause = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }
}

