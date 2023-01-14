using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript2 : MonoBehaviour
{
    public AudioSource audioScr;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            audioScr.Play();
            Destroy(gameObject, 0.2f);
        }

    }
}
