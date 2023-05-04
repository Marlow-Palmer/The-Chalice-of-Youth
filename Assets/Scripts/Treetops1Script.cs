using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Treetops1Script : MonoBehaviour
{
    public UnityEngine.UI.Button enemyButton;
    public PlayerImmortality playerDamageScript;
    public void GoBackButton()
    {
        SceneManager.LoadScene("TheForest1");
    }

    public void ExploreTheTreetopsMoreButton()
    {
        SceneManager.LoadScene("Treetops2");
    }

    public void EnemyButton()
    {
        if(playerDamageScript.isImmortal) // Check if the player is immortal
        {
            enemyButton.interactable = false;
            enemyButton.onClick.AddListener(DestroyButton);
        }
        else
        {

            Debug.Log("Player died");
        }
    }

    public void DestroyButton()
    {
        Destroy(gameObject);
        Debug.Log("Player killed the enemy");
    }
}
