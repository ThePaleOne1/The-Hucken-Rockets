﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    
    
    public GameObject confetti;
    public GameObject deathScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            print("kill me bitch");
            Instantiate(confetti, other.gameObject.transform.position,gameObject.transform.rotation);
			Invoke("Return", 3);
        } 
    }

	void Return()
	{
		SceneManager.LoadScene("MenuScene");
	}
}
