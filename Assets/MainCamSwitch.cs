using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamSwitch : MonoBehaviour
{
    public GameObject maincam;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SwitchCam", delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchCam()
    {
        print("yeeeett");
        maincam.SetActive(true);
    }
}
