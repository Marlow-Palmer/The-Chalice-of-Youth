using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImmortalTreetops1 : MonoBehaviour
{
    public UnityEngine.UI.Button enemyButton;
    public UnityEngine.UI.Button enemyButton2;

    public void GoBackButton()
    {
        SceneManager.LoadScene("ImmortalTheForest1");
    }

    public void KillEnemy()
    {
        Debug.Log("Enemy Killed");
        enemyButton.interactable = false;
        enemyButton.onClick.AddListener(DestroyButton);
    }

    public void KillEnemy2()
    {
        Debug.Log("Enemy Killed");
        enemyButton2.interactable = false;
        enemyButton2.onClick.AddListener(DestroyButton);
    }

    public void DestroyButton()
    {
        Destroy(gameObject);
        Debug.Log("Player killed the enemy");
    }
}
