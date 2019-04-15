using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullEnemy : MonoBehaviour
{
    public UnityEngine.UI.Text AttackSpeed;
    public float currentHealth;
    public float startingHealth;
    public int a = 1;
    public float timeBetweenAttacks;     // The time in seconds between each attack.
    public float attackDamage = 1;               // The amount of health taken away per attack.
    public Slider enemyhealthbar;
    public UnityEngine.UI.Text HP1;
    public Cash gold;
    GameObject player;                          // Reference to the player GameObject.
    GameObject player2;
    GameObject player3;
    GameObject player4;
    Warrior warrior;
    float timer;
    public string enemy;
    public PlayerExp exp;
    Rouge rouge;
    Mage mage;
    Priest priest;
    public Floor floor;
  //  EnemyHealthBar enemyHealth;

    public bool isDead;                                                // Whether the player is dead.

     public void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        warrior = player.GetComponent<Warrior>();
        player2 = GameObject.FindGameObjectWithTag("Player2");
        rouge = player2.GetComponent<Rouge>();
        player3 = GameObject.FindGameObjectWithTag("Player3");
        mage = player3.GetComponent<Mage>();
        player4 = GameObject.FindGameObjectWithTag("Player4");
        priest = player4.GetComponent<Priest>();
        MonsterStats();
        currentHealth = startingHealth;
      //  isDead = true;
    }

    void Update()
    {
        AttackSpeed.text = "AttackSpeed: " + timeBetweenAttacks;
        HP1.text = enemy + "\r\n" + currentHealth + "/" + startingHealth;
        timer += Time.deltaTime;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        // If the timer exceeds the time between attacks and this enemy is alive...
        if (timer >= timeBetweenAttacks && currentHealth > 0)
        {
            Attack();
        }

    }

     void Attack()
    {
        // Reset the timer.
        timer = 0f;

        // If the player has health to lose...
        //  if (playerHealth.currentHealth > 0)
        if (warrior.currentHealth > 0 || rouge.currentHealth > 0 || mage.currentHealth > 0 || priest.currentHealth > 0)
        {
            FindEnemy();
            // ... damage the player.
        }
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        enemyhealthbar.value = currentHealth;
        if (currentHealth <= 0 && !isDead)
        {
            Death();
            gold.Killed();
            exp.Killed();
            MonsterStats();

        }
    }
    public void Death()
    {
        isDead = true;
        timer = 0f;
        switch (a)
        {
            case 1:
                Debug.Log("You killed slime. You get " + gold.goldperkill + " gold" );
                return;
            case 2:
                Debug.Log("You killed rat. You get " + gold.goldperkill + " gold");
                return;
            case 3:
                Debug.Log("You killed mouse. You get " + gold.goldperkill + " gold");
                return;
        }
    }

    void MonsterStats()
    {
        int rnd = Random.Range(1, 4);
        switch (rnd)
        {
            case 1:
                enemy = "Slime";
                startingHealth = 30 * floor.maxFloor;
                currentHealth = 30 * floor.maxFloor;
                gold.goldperkill = 5 * floor.maxFloor;
                attackDamage = 10 * floor.maxFloor;
                timeBetweenAttacks = 2.0f * (1000 / (1000 + floor.maxFloor * 3)) ;
                exp.expperkill = 5 * floor.maxFloor;
                a = 1;
                break;
            case 2:
                enemy = "Rat";
                startingHealth = 15;
                currentHealth = 15;
                gold.goldperkill = 2;
                attackDamage = 5;
                timeBetweenAttacks = 1.5f * (1000 / (1000 + floor.maxFloor * 3));
                exp.expperkill = 2;
                a = 2;
                break;
            case 3:
                enemy = "Mouse";
                startingHealth = 5;
                currentHealth = 5;
                gold.goldperkill = 1;
                attackDamage = 3;
                timeBetweenAttacks = 1.2f * (1000 / (1000 + floor.maxFloor * 3));
                exp.expperkill = 1;
                a = 3;
                break;
        }
    }

    void FindEnemy()
    {
        int rnd = Random.Range(1, 5);
        switch (rnd)
        {
            case 1:
                if(warrior.currentHealth > 0)
                {
                    player = GameObject.FindGameObjectWithTag("Player");
                    warrior = player.GetComponent<Warrior>();
                    warrior.TakeDamage(attackDamage);
                }
                else
                {
                    goto case 2;
                }
                break;

            case 2:
                if (rouge.currentHealth > 0)
                {
                    player2 = GameObject.FindGameObjectWithTag("Player2");
                    rouge = player2.GetComponent<Rouge>();
                    rouge.TakeDamage(attackDamage);
                }
                else
                {
                    goto case 3;
                }
                break;
            case 3:
                if (mage.currentHealth > 0)
                {
                    player3 = GameObject.FindGameObjectWithTag("Player3");
                    mage = player3.GetComponent<Mage>();
                    mage.TakeDamage(attackDamage);
                }
                else
                {
                    goto case 4;
                }
                break;
            case 4:
                if (priest.currentHealth > 0)
                {
                    player4 = GameObject.FindGameObjectWithTag("Player4");
                    priest = player4.GetComponent<Priest>();
                    priest.TakeDamage(attackDamage);
                }
                else
                {
                    goto case 1;
                }
                break;
        }
    }

}
