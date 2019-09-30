using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractPush : MonoBehaviour
{
    public Animator anim;
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
            anim.SetBool("fallen", true);
        }
    }
}
