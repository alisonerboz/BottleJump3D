using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makine : MonoBehaviour
{
    AudioSource ses;
    void Start()
    {
        ses = GetComponent<AudioSource>();
    }



    private void OnCollisionEnter(Collision collision)
    {
        ses.Play();
    }
}
