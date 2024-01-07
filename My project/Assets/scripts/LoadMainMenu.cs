using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadMainMenu : MonoBehaviour
{

    public void LoadSceneByName()
    {
        SceneManager.LoadScene("mainmenu");
    }
    void Start()
    {
        SceneManager.LoadScene("mainmenu");
    }
}
