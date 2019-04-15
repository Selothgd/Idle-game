using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Warrior : MonoBehaviour {



    public float currentHealth;
    public float startingHealth = 120;
    public Slider healthbar;
    public UnityEngine.UI.Text HP1;
    bool isDead;                                                // Whether the player is dead.
    public dmgup dmg;
    public float timeBetweenHits = 1.5f;        // The time between each shot.
    public PlayerExp level;
    FullEnemy enemyHealthBar;
    float timer;                                    // A timer to determine when to fire.
    int shootableMask;                              // A layer mask so the raycast only hits things on the shootable layer.
                                                    /* void Awake()
                                                     {
                                                         // Create a layer mask for the Shootable layer.
                                                       //  shootableMask = LayerMask.GetMask("Shootable");
                                                     }
                                                     */
    GameObject enemy;
    GameObject enemy2;
    GameObject enemy3;
    GameObject enemy4;
    GameObject enemy5;
    GameObject enemy6;
    void Awake()
    {
        currentHealth = startingHealth;
        FindEnemy();
        healthbar.maxValue = startingHealth;
        healthbar.value = currentHealth;
    }

    void Update()
    {
        healthbar.maxValue = startingHealth;
        // Add the time since Update was last called to the timer.
        timer += Time.deltaTime;
        level.LvlUp();
        HP1.text = currentHealth + "/" + startingHealth;
        if (timer >= timeBetweenHits && currentHealth > 0 && enemyHealthBar.isDead == false)
        {
            FindEnemy();
            // ... attack.
            Attack();
        }

        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
    }

    public void TakeDamage(float amount)
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

    void Attack()
    {
        // Reset the timer.
        timer = 0f;
        if (currentHealth > 0 && enemy == false && enemy2 == false && enemy3 == false && enemy4 == false && enemy5 == false && enemy6 == false)
        {
            FindEnemy();
        }
        // ... damage the player.
        enemyHealthBar.TakeDamage(dmg.hero1Dmg);
    }
    void FindEnemy()
    {
        int rnd = Random.Range(1, 7);
        switch (rnd)
        {
            case 1:
                enemy = GameObject.FindGameObjectWithTag("Enemy");
                enemyHealthBar = enemy.GetComponent<FullEnemy>();
                break;
            case 2:
                enemy2 = GameObject.FindGameObjectWithTag("Enemy2");
                enemyHealthBar = enemy2.GetComponent<FullEnemy>();
                break;
            case 3:
                enemy3 = GameObject.FindGameObjectWithTag("Enemy3");
                enemyHealthBar = enemy3.GetComponent<FullEnemy>();
                break;
            case 4:
                enemy4 = GameObject.FindGameObjectWithTag("Enemy4");
                enemyHealthBar = enemy4.GetComponent<FullEnemy>();
                break;
            case 5:
                enemy5 = GameObject.FindGameObjectWithTag("Enemy5");
                enemyHealthBar = enemy5.GetComponent<FullEnemy>();
                break;
            case 6:
                enemy6 = GameObject.FindGameObjectWithTag("Enemy6");
                enemyHealthBar = enemy6.GetComponent<FullEnemy>();
                break;
        }
    }
}
