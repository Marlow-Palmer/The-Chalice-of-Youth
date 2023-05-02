using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerImmortality : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    public bool isImmortal = false;

    public GameObject chalice;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage();
        }
    }

    // Called when the player takes damage
    public void TakeDamage()
    {
        if (!isImmortal)
        {
            currentHealth--;

            if (currentHealth <= 0)
            {
                Die();
            }
            else
            {
                Debug.Log("Player took damage. Health: " + currentHealth);
            }
        }
    }

    // Called when the player collides with the chalice object
    public void CollectChalice()
    {
        chalice.SetActive(false);
        isImmortal = true;
    }

    // Called when the player dies
    public void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Player has died!");
    }

}
