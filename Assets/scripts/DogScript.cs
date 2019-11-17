using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogScript : MonoBehaviour

{

    public Animator Anim;
    //public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        // if(rb.velocity != new Vector3(0,0,0))
        {
            //Anim.SetBool("Walk", true);
            Anim.SetInteger("Walk", 1);
        }
        else
        {
            Anim.SetInteger("Walk", 0);

        }

        
    }
}
