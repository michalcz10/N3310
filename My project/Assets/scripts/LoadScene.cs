using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{

    public void LoadPong()
    {
        Invoke("DelayPong", 0.3f);
    }
    private void DelayPong()
    {
        SceneManager.LoadScene("Pong");
    }

    public void LoadMainMenu()
    {
        Invoke("DelayLoadMainMenu", 0.3f);
    }
    private void DelayLoadMainMenu()
    {
        SceneManager.LoadScene("mainmenu");
    }

    public void QuitApplication()
    {
        Invoke("DelayQuitApplication", 0.3f);
    }
    private void DelayQuitApplication()
    {
        Application.Quit();
    }
    public void LoadPongMenu()
    {
        Invoke("DelayPongMenu", 0.3f);
    }
    private void DelayPongMenu()
    {
        SceneManager.LoadScene("mainmenu-Pong");
    }
    public void LoadSnakeMenu()
    {
        Invoke("DelaySnakeMenu", 0.3f);
    }
    private void DelaySnakeMenu()
    {
        SceneManager.LoadScene("mainmenu-Snake");
    }
}
