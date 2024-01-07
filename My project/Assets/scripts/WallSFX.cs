using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSFX : MonoBehaviour
{

    public AudioClip WallHit;
    public AudioSource source;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "CollisionTag")
        {
            source.PlayOneShot(WallHit);
        }
        
    }
}
