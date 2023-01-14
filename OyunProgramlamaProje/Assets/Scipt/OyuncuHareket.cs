using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuHareket : MonoBehaviour
{
    Rigidbody2D rgb;
    [SerializeField] Vector3 velocity;
    public Animator animator;
    public GameObject bullet;
    public Transform atisNoktasi;
    public float atishizi =5000;

    public AudioSource audioScr;

    float speedAmount = 3.5f;
    float jumpAmount = 6.3f;
    // Start is called before the first frame update
    void Start()
    {
        
        rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * speedAmount * Time.deltaTime;
        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));


        //atesetme Animasyonu
        //ateskontrol
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
            audioScr.Play();
        }


        //ziplama
        if (Input.GetKeyDown(KeyCode.W) && Mathf.Approximately(rgb.velocity.y, 0))
        {
            rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
            animator.SetBool("Pjump", true);
        }
        //ziplamama
        if (animator.GetBool("Pjump") && Mathf.Approximately(rgb.velocity.y, 0))
        {
            animator.SetBool("Pjump", false);

        }

        //saga sola donme

        if (Input.GetAxisRaw("Horizontal")==-1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            atishizi = -5000;
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            atishizi = 5000;
        }
    }

    public void shoot()
    {
        
        GameObject mermi = Instantiate(bullet, atisNoktasi.position,Quaternion.identity);
        mermi.GetComponent<Rigidbody2D>().velocity = new Vector2(atishizi * Time.deltaTime, 0);
    }
}
