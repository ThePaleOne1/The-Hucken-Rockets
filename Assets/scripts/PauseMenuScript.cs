using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
	public bool paused = false;
	public GameObject UI;
    bool isReset = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (paused == false)
		{
			if (Input.GetButtonDown("Cancel"))
			{
				Time.timeScale = 0;
				UI.SetActive(true);
				paused = true;
			}
		}
	/*if (paused == true)
		{
			if (Input.GetButtonDown("Cancel"))
			{
				Time.timeScale = 1;
				UI.SetActive(false);
				paused = false;
			}
		}*/
    }

	public void Unpause()
	{
		Time.timeScale = 1;
		UI.SetActive(false);
		paused = false;
        
	}

	public void ReturnToMenu()
	{
		SceneManager.LoadScene("MenuScene");
		paused = false;
        
    }

    public void RestartGame()
    {
       
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1;
        
    }
}
