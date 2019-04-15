using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public float currentHealth;
    public float startingHealth;
    public Slider healthbar;
    public UnityEngine.UI.Text HP1;

    bool isDead;                                                // Whether the player is dead.                                       

     void Awake()
    {
        currentHealth = startingHealth;
    }

     void Update()
    {
        HP1.text = currentHealth + "/" + startingHealth;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        healthbar.value = currentHealth;
        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }
        void Death()
        {
            isDead = true;
             Debug.Log("You died, go to Town");
      }

    

}
