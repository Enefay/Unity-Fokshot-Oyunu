using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class veriTasima : MonoBehaviour
{
    public static veriTasima instance;

    public static int candegeri;
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
    void Update()
    {
        candegeri = tuzak.can;
    }

}
