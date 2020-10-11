using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PhysicsExperimentLoader : MonoBehaviour
{
    public void Experiment1()
    {
        SceneManager.LoadScene("co2 test");
        Time.timeScale = 1f;
    }

    public void Experiment4()
    {
        SceneManager.LoadScene("test");
        Time.timeScale = 1f;
    }

}