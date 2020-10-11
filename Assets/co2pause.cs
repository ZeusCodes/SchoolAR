using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class co2pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject ifinal;

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
        StartCoroutine(timewaste());
        ifinal = GameObject.Find("ifinal");
        ifinal.transform.position = new Vector3(-4.683f, -3323.25f, 3.685f);
        Destroy(ifinal);

    }

    IEnumerator timewaste()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
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
