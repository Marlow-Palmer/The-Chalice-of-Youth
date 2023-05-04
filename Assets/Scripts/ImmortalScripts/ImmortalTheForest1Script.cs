using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImmortalTheForest1Script : MonoBehaviour
{
    public void ExploreMoreOfTheForestButton()
    {
        SceneManager.LoadScene("ImmortalTheForest2");
    }

    public void GoBackButton()
    {
        SceneManager.LoadScene("ImmortalTheKingdom");
    }
}
