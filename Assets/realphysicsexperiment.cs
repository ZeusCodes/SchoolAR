using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class realphysicsexperiment : MonoBehaviour
{
    public void Experiment1()
    {
        SceneManager.LoadScene("physics1");
        Time.timeScale = 1f;
    }
}