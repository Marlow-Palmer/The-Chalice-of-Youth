using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackToKingButton : MonoBehaviour
{
    public GameObject player;
    public float distanceThreshold = 3.0f;
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
    }

    public PlayerImmortality playerDamageScript;

    void Update()
    {
        // Show or hide the button based on the player's isImmortal status
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.gameObject.SetActive(playerDamageScript.isImmortal);
        }
    }
}
