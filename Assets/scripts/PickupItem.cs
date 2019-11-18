using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    GameObject heldObject;
    public bool isHolding = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (isHolding && Input.GetKey(KeyCode.Q))
        //{
        //    isHolding = false;
        //}

        if (isHolding)
        {
            heldObject.transform.position = transform.position;
            heldObject.GetComponent<Rigidbody>().detectCollisions = false;
            heldObject.GetComponent<Rigidbody>().isKinematic = false;
        }
        else
        {
            heldObject.GetComponent<Rigidbody>().detectCollisions = true;
            heldObject.GetComponent<Rigidbody>().isKinematic = true;
            heldObject = null;
        }
    }

    private void OnTriggerStay(Collider col)
    {
   
        if (col.gameObject.tag == "Pickup" && Input.GetKeyDown(KeyCode.Q))
        {
            print("you can pick up the box");
            isHolding = true;
            heldObject = col.gameObject;
            //col.gameObject.transform.position = transform.position;
        }

        
    }
}
