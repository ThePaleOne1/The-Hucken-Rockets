using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogScript : MonoBehaviour

{

    public Animator Anim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            //Anim.SetBool("Walk", true);
            Anim.SetInteger("Walk", 1);
        }
        else
        {
            Anim.SetInteger("Walk", 2);
        }

        
    }
}
