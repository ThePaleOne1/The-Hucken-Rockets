using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractPush : MonoBehaviour
{
    public Animator anim;
    public AudioSource audioS;
    public AudioClip chairPush;
    //public Animator pAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (!(other.gameObject.tag == "Player"))
            return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("isPushed", true);
            audioS.PlayOneShot(chairPush);
            //pAnim.SetBool("Is Pushing", true);
        }
        
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    pAnim.SetBool("Is Pushing", false);
    //}





}
