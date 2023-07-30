using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    AudioSource ses;
    void Start()
    {
        ses = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        ses.Play();
    }
}
