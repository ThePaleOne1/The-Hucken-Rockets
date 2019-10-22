using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamSwitch : MonoBehaviour
{
    public GameObject maincam;
    public GameObject CutsceneCam;
    public float delay;
    public RigidbodyCharacter pInput;
	public GameObject CollectibleUI;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SwitchCam", delay);
        pInput.IsInputEnabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchCam()
    {
        pInput.IsInputEnabled = true;
        //print("yeeeett");
        maincam.SetActive(true);
        CutsceneCam.SetActive(false);
		CollectibleUI.SetActive(true);
	}
}
