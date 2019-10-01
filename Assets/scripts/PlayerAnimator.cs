using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour

{

    public Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            Anim.SetBool("Is walking", true);
        }
        else
        {
            Anim.SetBool("Is walking", false);
        }

        if(Input.GetButtonDown("Jump"))
        {
            Anim.SetBool("Is Jumping", true);
        }
        else
        {
            Anim.SetBool("Is Jumping", false);
        }

    }
}   
