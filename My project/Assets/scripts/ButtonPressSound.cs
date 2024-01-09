using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressSound : MonoBehaviour
{
    public AudioClip ButtonPress;
    public AudioSource source;

    public void SoundOnClick()
    {
        source.PlayOneShot(ButtonPress);
    }

}
