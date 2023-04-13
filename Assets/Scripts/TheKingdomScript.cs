using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheKingdomScript : MonoBehaviour
{
    public void ToTheForestButton()
    {
        SceneManager.LoadScene("TheForest1");
    }

    public void GoBackButton()
    {
        SceneManager.LoadScene("QuestCompleteScene");
    }
}
