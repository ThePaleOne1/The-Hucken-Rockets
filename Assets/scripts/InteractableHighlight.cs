using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableHighlight : MonoBehaviour
{
    public Material intMat;
    public Material originalMat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Interactable")
        {
            //originalMat = other.GetComponent<Material>();
            //other.GetComponent<Material>().CopyPropertiesFromMaterial(intMat);
            other.GetComponent<Renderer>().material = intMat;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Interactable")
        {
            other.GetComponent<Renderer>().material = originalMat;
            //other.GetComponent<Material>().CopyPropertiesFromMaterial(originalMat);
        }
    }
}
