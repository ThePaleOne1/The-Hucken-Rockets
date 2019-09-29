using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGenerator : MonoBehaviour
{
    public GameObject tvRemote;
    //public GameObject tvSound;
    public AudioSource sound;
    public bool soundDetection = false;

    public GameObject collidedObject; //need this variable outside of the OnCollisionEnter

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == tvRemote)
        {
            sound.Play();
            soundDetection = true;
            print("remote just turned the tv on!!!");

            collidedObject = collision.collider.gameObject;
        }
        else
        {
            soundDetection = false;
        }
    }
}
