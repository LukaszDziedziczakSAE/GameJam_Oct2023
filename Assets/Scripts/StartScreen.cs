using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public void OnStartPress()
    {
        SceneManager.LoadScene(1);
    }

    public void OnExitPress()
    {
        Application.Quit();
    }
}
