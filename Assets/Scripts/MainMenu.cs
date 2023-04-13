using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("OpeningScene");
    }

    public void SaveGame()
    {
        SceneManager.LoadScene("LoadScene");
    }

    public void OptionsButton()
    {
        SceneManager.LoadScene("OptionsScene");
    }

    public void QuitGame()
    {
        //put the debug log so that i know the quit button is working
        //because it wont just quit the game while running in unity
        Debug.Log("Quit");
        Application.Quit();
    }
}
