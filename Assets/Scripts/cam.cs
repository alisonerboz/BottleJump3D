using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    AudioSource ses;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ses = GetComponent<AudioSource>();
    }



    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag!="nesneler")
        {
            ses.Play();
            if (gameObject.tag == "cam")
            {
                rb.isKinematic = false;
            }
        }
        
        
    }
}
