using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanavarZiplama : MonoBehaviour
{
    public float hiz, deger;
    public Transform varilacakYer01, varilacakYer02;
    Rigidbody2D rgb;
    public float jumpAmount;
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
        gameObject.transform.Translate(new Vector3(deger * hiz * Time.deltaTime, 0, 0));


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "varilacak")
        {
            deger *= -1;
            gameObject.transform.localScale = new Vector3(-3 * deger, 3, 3);
        }
    }
}

