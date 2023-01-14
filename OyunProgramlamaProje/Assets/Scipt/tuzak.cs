using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tuzak : MonoBehaviour
{
    public AudioSource audioScr;
    public AudioSource dusmeSesi;
    public static int can = 3;
    public Animator animator;
    public GameObject[] kalpObje;
    public GameObject TekrarDene;



    void Update()
    {
        can = veriTasima.candegeri;
        if (can == 2)
        {
            kalpObje[can].SetActive(false);
        }
        if (can == 1)
        {
            kalpObje[can].SetActive(false);
            kalpObje[can+1].SetActive(false);
        } 

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Tuzak")
        {
            can--;
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 5, ForceMode2D.Impulse);
            
            audioScr.Play();
            canKontrol();
        }

        if (collision.gameObject.tag == "Kurbaga")
        {
            can--;
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 5, ForceMode2D.Impulse);
            audioScr.Play();
            canKontrol();

        }
    }
    void canKontrol()
    {

        if(can<=0)
        {
            animator.SetBool("Ptryagain", true);
            GetComponent<OyuncuHareket>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            dusmeSesi.Play();
            Destroy(gameObject,1.5f);
            if (TekrarDene.activeInHierarchy == true)
            {
                TekrarDene.SetActive(false);
            }
            else
            {
                TekrarDene.SetActive(true);
            }
        }
        else
        {
            TekrarDene.SetActive(false);
        }
    }

    public void tekrarDene()
    {
        SceneManager.LoadScene("Menu");
        can = 3;
    }
}