using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{

    public void LoadPong()
    {
        SceneManager.LoadScene("Pong");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("mainmenu");
    }
    public void QuitApplication()
    {
        Application.Quit();
    }
}
