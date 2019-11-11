using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCamSwitch : MonoBehaviour
{
    public GameObject maincam;
    public GameObject CutsceneCam;
    public float delay;
    public RigidbodyCharacter pInput;

    bool isSkippable = false;
    
	//public GameObject CollectibleUI;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SwitchCam", delay);
        Invoke("Skippable", 2f);
        pInput.IsInputEnabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isSkippable)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void Skippable()
    {
        isSkippable = true;
    }

    public void SwitchCam()
    {
        //pInput.IsInputEnabled = true;
        //print("yeeeett");
        //maincam.SetActive(true);
        //CutsceneCam.SetActive(false);
        //CollectibleUI.SetActive(true);

        SceneManager.LoadScene(2);
	}
}
