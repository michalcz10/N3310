using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadscene : MonoBehaviour
{

    public void LoadSceneByName()
    {
        SceneManager.LoadScene("Pong");
    }

}
