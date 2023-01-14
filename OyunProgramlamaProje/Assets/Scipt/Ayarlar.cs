using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ayarlar : MonoBehaviour
{
    public Button SesKontrolButonu;
    bool ButonKontrolBool;
    
    void Start()
    {
        ButonKontrolBool = false;
        AudioListener.pause = false;
    }
    void Update()
    {


    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ButonKontrol()
    {
        if (ButonKontrolBool == false)
        {
            ButonKontrolBool = true;
            AudioListener.pause = true;
        }
        else
        {
            ButonKontrolBool = false;
            AudioListener.pause = false;
        }

    }
}
