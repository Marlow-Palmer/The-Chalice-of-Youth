using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheForest2Script : MonoBehaviour
{
    public void GoBackButton()
    {
        SceneManager.LoadScene("TheForest1");
    }

    public void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Player has died!");
    }
}
