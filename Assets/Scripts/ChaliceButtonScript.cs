using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ChaliceButtonScript : MonoBehaviour
{
    public UnityEngine.UI.Button chaliceButton;
    public PlayerImmortality playerDamageScript;

    // Start is called before the first frame update
    void Start()
    {
        chaliceButton.onClick.AddListener(CollectChalice);
    }

    // Called when the chalice button is clicked
    public void CollectChalice()
    {
        playerDamageScript.CollectChalice();
        chaliceButton.interactable = false;
        chaliceButton.onClick.AddListener(DestroyButton);
    }

    void DestroyButton()
    {
        Destroy(gameObject);
        Debug.Log("Player collected The Chalice");
    }
}
