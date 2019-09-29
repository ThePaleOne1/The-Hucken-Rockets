using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbable : MonoBehaviour
{
    [SerializeField] 
    float climbSpeed = 0.1f;


    void Start()
    {

    }


    void Update()
    {

    }



    void OnTriggerStay(Collider other)
    {
        if (!(other.gameObject.tag == "Player"))
            return;

        if (Input.GetKeyDown(KeyCode.E))
        {
            other.GetComponent<RigidbodyCharacter>().isClimbing = !other.GetComponent<RigidbodyCharacter>().isClimbing;
        }

        if (other.GetComponent<RigidbodyCharacter>().isClimbing)
        {
            other.attachedRigidbody.useGravity = false;

            float y;
            if (Input.GetAxis("Vertical") != 0)
            {
                y = Mathf.Abs(Input.GetAxis("Vertical") * climbSpeed);
            }
            else if (Input.GetAxis("Horizontal") != 0)
            {
                y = Mathf.Abs(Input.GetAxis("Horizontal") * climbSpeed);
            }
            else
            {
                y = -climbSpeed;
            }

            other.transform.Translate(new Vector3(0, y, 0));
        }
        else
        {
            other.attachedRigidbody.useGravity = true;
        }

        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<RigidbodyCharacter>().isClimbing = false;
            other.attachedRigidbody.useGravity = true;
        }
    }
}
