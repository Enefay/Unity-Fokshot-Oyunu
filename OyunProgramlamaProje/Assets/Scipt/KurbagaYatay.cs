using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KurbagaYatay : MonoBehaviour
{
    public float hiz, deger;
    public Transform varilacakYer01, varilacakYer02;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.Translate(new Vector3(deger * hiz * Time.deltaTime, 0, 0));


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="varilacak")
        {
            deger *= -1;
            gameObject.transform.localScale = new Vector3(-3 * deger, 3, 3);
        }
    }
}
