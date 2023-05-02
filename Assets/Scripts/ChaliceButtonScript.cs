using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class ChaliceButtonScript : MonoBehaviour
{
    public UnityEngine.UI.Button chaliceButton;
    public PlayerImmortality playerDamageScript;
    public TextMeshProUGUI Output;

    // Start is called before the first frame update
    void Start()
    {
        chaliceButton.onClick.AddListener(CollectChalice);
    }

    // Called when the chalice button is clicked
    public void CollectChalice()
    { 
        Debug.Log("CollectChalice");
        playerDamageScript.CollectChalice();
        chaliceButton.interactable = false;
        chaliceButton.onClick.AddListener(DestroyButton);
        Output.text = " ";
    }

    public void DestroyButton()
    {
        Destroy(gameObject);
        Debug.Log("Player collected The Chalice");
    }
}
