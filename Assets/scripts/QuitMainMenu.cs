using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitMainMenu : MonoBehaviour
{
	public Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void QuitGame()
	{
		Anim.SetBool("Quit", true);
		Invoke( "End", 3);
	}

	void End()
	{
		Application.Quit();
	}
}
