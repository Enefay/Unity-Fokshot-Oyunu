using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sesTasima : MonoBehaviour
{
    public static sesTasima instance;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

}
