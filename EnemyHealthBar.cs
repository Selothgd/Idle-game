using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{

    public float currentHealth;
    public float startingHealth;
    public Slider enemyhealthbar;
    public UnityEngine.UI.Text HP1;
    public Cash gold;
    public int a = 1;
    EnemyAttack attack;


    public bool isDead;                                                // Whether the player is dead.

    public void Awake()
    {
        int rnd = Random.Range(1, 4);
        switch (rnd)
        {
            case 1:
                startingHealth = 30;
                currentHealth = 30;
                gold.goldperkill = 5;
                a = 1;
                return;
            case 2:
                startingHealth = 15;
                currentHealth = 15;
                gold.goldperkill = 2;
                a = 2;
                return;
            case 3:
                startingHealth = 5;
                currentHealth = 5;
                gold.goldperkill = 1;
                a = 3;
                return;
        }
        //       startingHealth = PlayerPrefs.GetFloat("MaxHeroHealth");
        currentHealth = startingHealth;
        isDead = false;
        //  healthbar.value = CalculatedHealth();
    }

    void Update()
    {
        HP1.text = currentHealth + "/" + startingHealth;
        if(currentHealth < 0)
        {
            currentHealth = 0;
        }
    }

    public void TakeDamage(float amount)
    {
        //damaged = true;
        currentHealth -= amount;
        enemyhealthbar.value = currentHealth;
        if (currentHealth <= 0 && !isDead)
        {
            Death();
            gold.Killed();
            int rnd = Random.Range(1, 4);
            switch (rnd)
            {
                case 1:
                    startingHealth = 30;
                    currentHealth = 30;
                    gold.goldperkill = 5;
                    a = 1;
                    return;
                case 2:
                    startingHealth = 15;
                    currentHealth = 15;
                    gold.goldperkill = 2;
                    a = 2;
                    return;
                case 3:
                    startingHealth = 5;
                    currentHealth = 5;
                    gold.goldperkill = 1;
                    a = 3;
                    return;
            }
        }
    }
    public void Death()
    {
        isDead = true;
        switch (a)
        {
            case 1:
                Debug.Log("You killed slime");
                return;
            case 2:
                Debug.Log("You killed rat");
                return;
            case 3:
                Debug.Log("You killed mouse");
                return;
        }
    }

}
