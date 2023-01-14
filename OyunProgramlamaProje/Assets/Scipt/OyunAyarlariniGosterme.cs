using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunAyarlariniGosterme : MonoBehaviour
{
    public GameObject oyunIciAyar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void oyunIciAyarGoster()
    {
        if (oyunIciAyar.activeInHierarchy == true)
        {
            oyunIciAyar.SetActive(false);
        }
        else
        {
            oyunIciAyar.SetActive(true);
        }
    }
}
