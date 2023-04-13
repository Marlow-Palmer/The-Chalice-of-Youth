using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{ 
    public void ResumeButton()
    {
        SceneManager.LoadScene("OptionsScene");
    }
    
    public void OptionsButton()
    {
        SceneManager.LoadScene("OptionsScene");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("StartScreenScene");
    }
}
