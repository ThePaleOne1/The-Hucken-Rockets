﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeldObjectVariable : MonoBehaviour
{
    public GameObject heldObj;
    public GameObject physicsObj;

    public AudioSource aSource;
    public AudioClip CollideSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        aSource.PlayOneShot(CollideSound);
    }
}
