using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class QuestCompleteScript : MonoBehaviour
{
    public TextMeshProUGUI Output;
    private int numClicks = 0;
    public PlayerImmortality playerDamageScript;

    public void NextButton()
    {
        /*if (playerDamageScript.isImmortal != true)
        {
            Output.text = "You have not completed your quest yet.";
            numClicks = numClicks + 1;
            if (numClicks == 1)
            {
                SceneManager.LoadScene("TheKingdomScene");
            }
        }
        else
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
        }*/
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
