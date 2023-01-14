using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunuDurdurDevamet : MonoBehaviour
{
    public bool oyundurumu = false;
    public void durdurDevamet()
    {
        if (oyundurumu == false)
        {
            Time.timeScale = 0f;
            oyundurumu = true;
        }
        else if (oyundurumu == true)
        {
            Time.timeScale = 1f;
            oyundurumu = false;
        }

    }
}
