using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    GameObject physicsObject;
    GameObject heldObject;
    public bool isHolding = false;
    public GameObject pickupZone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (isHolding)
        //{
        //    heldObject.transform.SetPositionAndRotation(transform.position, transform.rotation);
        //}
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.transform.tag == "Pickup" && Input.GetKeyDown(KeyCode.E))
        {
            if (!isHolding)
            {
                //if (col.gameObject.GetComponent<HeldObjectVariable>() != null)
                //{
                physicsObject = col.gameObject.GetComponent<HeldObjectVariable>().physicsObj;
                heldObject = col.gameObject.GetComponent<HeldObjectVariable>().heldObj;
                //}
                heldObject.GetComponent<HeldObjectFollowPlayer>().pickupZone = gameObject;
                isHolding = true;

                Destroy(col.gameObject);
                Instantiate(heldObject, transform.position, transform.rotation);
                
                //col.transform.SetParent(transform);
            }
            else
            {
                isHolding = false;
                print("does is get to this section???");
                Destroy(col.gameObject);
                print("i assume its not getting to this point");
                Instantiate(physicsObject, transform.position, transform.rotation);
                print("what about this line????");
            }
            
        }
       

        
    }
}
