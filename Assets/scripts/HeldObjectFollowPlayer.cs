using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeldObjectFollowPlayer : MonoBehaviour
{
    public GameObject pickupZone;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.SetPositionAndRotation(pickupZone.transform.position, pickupZone.transform.rotation);
    }

    
}
