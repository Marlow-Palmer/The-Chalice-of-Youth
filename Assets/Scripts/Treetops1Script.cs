using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Treetops1Script : MonoBehaviour
{
    public void GoBackButton()
    {
        SceneManager.LoadScene("TheForest1");
    }

    public void ExploreTheTreetopsMoreButton()
    {
        SceneManager.LoadScene("Treetops2");
    }
}
