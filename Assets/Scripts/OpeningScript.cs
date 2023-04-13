using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningScript : MonoBehaviour
{
    public void GoForthButton()
    {
        SceneManager.LoadScene("TheKingdomScene");
    }
}
