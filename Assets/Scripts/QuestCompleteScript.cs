using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class QuestCompleteScript : MonoBehaviour
{
    public TextMeshProUGUI Output;
    private int numClicks = 0;

    public void NextButton()
    {
        numClicks = numClicks + 1;
        if (numClicks == 1)
        {
            Output.text = "What was that noise???";
        }
        else if (numClicks == 2)
        {
            Output.text = "The Kingdom is under attack! You must go and protect us!";
        }
        else if (numClicks == 3)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
