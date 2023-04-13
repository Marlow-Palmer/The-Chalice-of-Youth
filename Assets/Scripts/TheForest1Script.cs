using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheForest1Script : MonoBehaviour
{
    public void ExploreTheTreetopsButton()
    {
        SceneManager.LoadScene("Treetops1");
    }

    public void ExploreMoreOfTheForestButton()
    {
        SceneManager.LoadScene("TheForest2");
    }

    public void GoBackButton()
    {
        SceneManager.LoadScene("TheKingdomScene");
    }
}
