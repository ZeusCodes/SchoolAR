using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class testmenu : MonoBehaviour
{
    public static bool GameIsPaused = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("Resume");
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
        Debug.Log("Paused");
    }


    public void QuitGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
