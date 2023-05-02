using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageScript : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public GameObject deathEffect;

    // Called when the enemy object is created
    void Start()
    {
        currentHealth = maxHealth;
    }


    //ASK PROFESSOR ABOUT THIS

    // Called when the enemy object takes damage
    /*public void TakeDamage(int damage)
    {
        if (PlayerImmortality.isImmortal) // Check if the player is immortal
        {
            Die(); // The enemy dies if the player is immortal
        }
        else
        {
            PlayerImmortality playerDamageScript = FindObjectOfType<PlayerImmortality>(); // Find the player damage script
            playerDamageScript.Die(); // The player dies if the player is not immortal
        }
    }
    */

    // Called when the enemy object dies
    void Die()
    {
        if (deathEffect != null)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
    }
}
