using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuTimerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadMainMenu", 5f);
    }
    private void LoadMainMenu()
    {
        SceneManager.LoadScene("mainmenu");
    }
}
