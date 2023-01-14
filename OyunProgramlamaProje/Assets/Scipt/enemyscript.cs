using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    public AudioSource audioScr;
    public Animator animator;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="bullet")
        {
            animator.SetBool("kurbagaolum", true);
            audioScr.Play();
            Destroy(gameObject, 0.2f);
        }
        
    }
}
