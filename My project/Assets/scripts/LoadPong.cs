using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadPong : MonoBehaviour
{

    public void LoadSceneByName()
    {
        SceneManager.LoadScene("Pong");
    }

}
