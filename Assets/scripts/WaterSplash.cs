using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSplash : MonoBehaviour
{
    public AudioClip Sploosh;
    public AudioSource UAS;
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

    
    if (other.gameObject.tag == "Player")
        {
            UAS.PlayOneShot(Sploosh);
        }
    
        
    }
}
