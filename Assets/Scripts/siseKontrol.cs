using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class siseKontrol : MonoBehaviour
{
    Rigidbody rb;
    public float zForce, yForce;
    AudioSource ses;
    Animator anim;
    bool havada=false;
    int ziplamaHakki=2;
    int skor=0;
    public Text skorText;
    int seviye=1;
    public Text seviyeText;
    Vector3 SpawnPoint;
    void Start()
    {
        
        SpawnPoint = gameObject.transform.position;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        ses = GetComponent<AudioSource>();
        
    }

    
    void Update()
    {
        skorText.text = ("SCORE : "+skor.ToString());
        seviyeText.text = ("LEVEL : "+seviye.ToString());
        /*if(!havada)
        {
            anim.SetBool("flip", false);
        }*/
        if (ziplamaHakki>0)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                rb.velocity = new Vector3(0, yForce, zForce);

                anim.SetTrigger("FLIP");
                ziplamaHakki--;
                Debug.Log(ziplamaHakki);

            }
        }
        if(Input.GetKeyUp(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        if (Input.GetKeyUp(KeyCode.P))
        {
            if (Time.timeScale == 1)
                Time.timeScale = 0;
            else if (Time.timeScale == 0)
                Time.timeScale = 1;
        }

    }
    private void FixedUpdate()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "nesneler")
        {
            //havada = false;
            ziplamaHakki = 2;
        }
        
        if (collision.gameObject.tag == "lavabo")
        {
            //havada = false;
            ziplamaHakki = 2;
        }
        
        if (collision.gameObject.tag == "tv")
        {
            //havada = false;
            ziplamaHakki = 2;
        }
        if (collision.gameObject.tag == "aský")
        {
            //havada = false;
            ziplamaHakki = 2;
        }
        if (collision.gameObject.tag == "cam")
        {
            //havada = false;
            ziplamaHakki = 2;
            Destroy(collision.gameObject,1.5f);
        }
        if (collision.gameObject.tag == "makine")
        {
            //havada = false;
            ziplamaHakki = 2;
        }
        if (collision.gameObject.tag == "isik")
        {
            //havada = false;
            ziplamaHakki = 2;
        }
        if (collision.gameObject.tag == "klozet")
        {
            //havada = false;
            ziplamaHakki = 2;
        }

        if (collision.gameObject.tag == "zemin")
        {
            gameObject.transform.position = SpawnPoint;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (collision.gameObject.tag == "check")
        {
            ziplamaHakki = 2;
            SpawnPoint = gameObject.transform.position;
            

        }
        if (collision.gameObject.tag == "Finish")
        {

            rb.velocity = Vector3.zero;
            StartCoroutine(yeniden());
            Time.timeScale = 0.1f;


        }

    }
    IEnumerator yeniden()
    {
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            skor++;
            ses.Play();
            Destroy(other.gameObject);
            
        }
        if (other.gameObject.tag == "level2")
        {
            seviye = 2;
        }
        if (other.gameObject.tag == "level3")
        {
            seviye = 3;
        }
        if (other.gameObject.tag == "level4")
        {
            seviye = 4;
        }
        if (other.gameObject.tag == "level5")
        {
            seviye = 5;
        }
        if (other.gameObject.tag == "level6")
        {
            seviye = 6;
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "nesneler")
        {
            //havada = true;
        }
    }
}
