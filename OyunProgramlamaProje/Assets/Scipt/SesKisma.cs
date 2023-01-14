using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKisma : MonoBehaviour
{
  public void SetVolume(float value)
    {
        AudioListener.volume = value;
    }
}
