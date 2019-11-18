using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    //the level that needs to be loaded - mainly for the play button
    private int levelToLoad;

    public GameObject Options;
    public GameObject HowToPlay;

    //loads the game scene
    public void PlayGame()
    {
        SceneManager.LoadScene(1);

        Debug.Log("play game");
    }

    public void OptionsOpen()
    {
        Options.SetActive(true);
    }

    public void HowTo()
    {
        HowToPlay.SetActive(true);
    }

    //link to the "exit" button, will close game when pressed.
    //public void QuitGame()
    //{
    //    Application.Quit();
    //    Debug.Log("quit game");
    //}   Check 'QuitMainMenu' script for new Application.Quit();.
}
