using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    //the level that needs to be loaded - mainly for the play button
    private int levelToLoad;

    //variable for the how to image
    public Image howTo;

    //variable for the options panel
    public Image options;

    // Start is called before the first frame update
    void Start()
    {
        //when the game starts, the how to play menu will be disabled.
        howTo.enabled = false;

        for(int i = 0; i < howTo.transform.childCount; ++i)
        {
            var child = howTo.transform.GetChild(i).gameObject;
            if (child != null)
            {
                child.SetActive(false);
            }
        }

        Debug.Log("how to play is closed");

        //when the game starts, the options menu will be disabled
        options.enabled = false;

        for (int i = 0; i < options.transform.childCount; ++i)
        {
            var child = howTo.transform.GetChild(i).gameObject;
            if (child != null)
            {
                child.SetActive(false);
            }
        }
    }

    //loads the game scene
    public void PlayGame()
    {
        SceneManager.LoadScene(1);

        Debug.Log("play game");
    }

    //when the "how to play" button is pressed, it'll be enabled
    public void HowTo()
    {
        howTo.enabled = true;

        for (int i = 0; i < howTo.transform.childCount; ++i)
        {
            var child = howTo.transform.GetChild(i).gameObject;
            if (child != null)
            {
                child.SetActive(true);
            }
        }
        Debug.Log("how to");
    }

    //when the "how to play" menu is closed, it'll close. (there would be an "x" button on it)
    public void CloseHowTo()
    {
        howTo.enabled = false;

        for (int i = 0; i < howTo.transform.childCount; ++i)
        {
            var child = howTo.transform.GetChild(i).gameObject;
            if (child != null)
            {
                child.SetActive(false);
            }
        }
    }

    //when pressed, the options menu will open
    public void Options()
    {
        Debug.Log("options button pressed");
        options.enabled = true;

        for (int i = 0; i < options.transform.childCount; ++i)
        {
            var child = howTo.transform.GetChild(i).gameObject;
            if (child != null)
            {
                child.SetActive(true);
            }
        }
    }

    //when added, the options menu will close on a button click when linked to the button
    public void CloseOptions()
    {
        for (int i = 0; i < options.transform.childCount; ++i)
        {
            var child = options.transform.GetChild(i).gameObject;
            if (child != null)
            {
                child.SetActive(false);
            }
        }
    }

    //link to the "exit" button, will close game when pressed.
    //public void QuitGame()
    //{
    //    Application.Quit();
    //    Debug.Log("quit game");
    //}   Check 'QuitMainMenu' script for new Application.Quit();.
}
