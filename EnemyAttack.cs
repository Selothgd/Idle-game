using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    public float timeBetweenAttacks = 0.5f;     // The time in seconds between each attack.
    public int attackDamage;               // The amount of health taken away per attack.

    GameObject player;                          // Reference to the player GameObject.
    HealthBar playerHealth;                  // Reference to the player's health.
    EnemyHealthBar enemyHealth;                    // Reference to this enemy's health.
    float timer;                                // Timer for counting up to the next attack.

    void Awake()
    {
        // Setting up the references.
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<HealthBar>();
        enemyHealth = GetComponent<EnemyHealthBar>();
    }

  void Update()
    {
        // Add the time since Update was last called to the timer.
        timer += Time.deltaTime;

        // If the timer exceeds the time between attacks, the player is in range and this enemy is alive...
        if (timer >= timeBetweenAttacks && enemyHealth.currentHealth > 0)
        {
            // ... attack.
            Attack();
        }

        // If the player has zero or less health...
        /*       if (playerHealth.currentHealth <= 0)
               {
                   // ... tell the animator the player is dead.
                   anim.SetTrigger("PlayerDead");
               } 
               */
    }


    void Attack()
    {
        // Reset the timer.
        timer = 0f;

        // If the player has health to lose...
        if (playerHealth.currentHealth > 0)
        {
            // ... damage the player.
            playerHealth.TakeDamage(attackDamage);
        }
    }
}
