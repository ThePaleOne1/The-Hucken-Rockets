using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorProgression : MonoBehaviour
{
    public Collectable colScript;
    public int count;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (colScript.collectableCount == count)
        {
            anim.SetBool("isOpen", true);
        }
        else
        {
            anim.SetBool("isOpen", false);
        }
    }
}
