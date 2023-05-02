using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideButton : MonoBehaviour
{
    public GameObject player;
    public float distanceThreshold = 3.0f;
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
    }

    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        button.gameObject.SetActive(distance <= distanceThreshold);
    }
}
