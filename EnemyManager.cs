using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{

    // public Warrior playerHealth;       // Reference to the player's heatlh.
    public FullEnemy enemy1;
    public FullEnemy enemy2;
    public FullEnemy enemy3;
    public FullEnemy enemy4;
    public FullEnemy enemy5;
    public FullEnemy enemy6;
    public Slider enemyhealthbar1;
    public Slider enemyhealthbar2;
    public Slider enemyhealthbar3;
    public Slider enemyhealthbar4;
    public Slider enemyhealthbar5;
    public Slider enemyhealthbar6;
    //public float spawnTime = 3f;            // How long between each spawn.
    public int killCount;


    void Awake()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        //    Spawn();
        enemyhealthbar1.maxValue = enemy1.startingHealth;
        enemyhealthbar2.maxValue = enemy2.startingHealth;
        enemyhealthbar3.maxValue = enemy3.startingHealth;
        enemyhealthbar4.maxValue = enemy4.startingHealth;
        enemyhealthbar5.maxValue = enemy5.startingHealth;
        enemyhealthbar6.maxValue = enemy6.startingHealth;

    }
    public void Update()
    {
        if (enemy1.isDead == true || enemy2.isDead == true || enemy3.isDead == true || enemy4.isDead == true || enemy5.isDead == true || enemy6.isDead == true )
        {
            Spawn();
        }

    }


    public void Spawn()
    {
        // If the player has no health left...
/*        if (playerHealth.currentHealth <= 0f)
        {
            // ... exit the function.
            return;
        } */
        if (enemy1.isDead == true)
        {
            countingKills();
            enemy1.isDead = false;        
        }
        if (enemy2.isDead == true)
        {
            countingKills();
            enemy2.isDead = false;
        }
        if (enemy3.isDead == true)
        {
            countingKills();
            enemy3.isDead = false;
        }
        if (enemy4.isDead == true)
        {
            countingKills();
            enemy4.isDead = false;
        }
        if (enemy5.isDead == true)
        {
            countingKills();
            enemy5.isDead = false;
        }
        if (enemy6.isDead == true)
        {
            countingKills();
            enemy6.isDead = false;
        }
        enemyhealthbar1.maxValue = enemy1.startingHealth;
        enemyhealthbar1.value = enemy1.startingHealth;
        enemy1.currentHealth = enemy1.startingHealth;

        enemyhealthbar2.maxValue = enemy2.startingHealth;
        enemyhealthbar2.value = enemy2.startingHealth;
        enemy2.currentHealth = enemy2.startingHealth;

        enemyhealthbar3.maxValue = enemy3.startingHealth;
        enemyhealthbar3.value = enemy3.startingHealth;
        enemy3.currentHealth = enemy3.startingHealth;

        enemyhealthbar4.maxValue = enemy4.startingHealth;
        enemyhealthbar4.value = enemy4.startingHealth;
        enemy4.currentHealth = enemy4.startingHealth;

        enemyhealthbar5.maxValue = enemy5.startingHealth;
        enemyhealthbar5.value = enemy5.startingHealth;
        enemy5.currentHealth = enemy5.startingHealth;

        enemyhealthbar6.maxValue = enemy6.startingHealth;
        enemyhealthbar6.value = enemy6.startingHealth;
        enemy6.currentHealth = enemy6.startingHealth;

    }
    public void countingKills()
    {
       // if (enemy1.isDead == !true || enemy2.isDead == !true || enemy3.isDead == !true || enemy4.isDead == !true || enemy5.isDead == !true || enemy6.isDead == !true)
       // {
            if (enemy1.isDead == true)
            {
                killCount = killCount + 1;
            }
            if (enemy2.isDead == true)
            {
                killCount = killCount + 1;
            }
            if (enemy3.isDead == true)
            {
                killCount = killCount + 1;
            }
            if (enemy4.isDead == true)
            {
                killCount = killCount + 1;
            }
            if (enemy5.isDead == true)
            {
                killCount = killCount + 1;
            }
            if (enemy6.isDead == true)
            {
                killCount = killCount + 1;
            }
      //  }
    }
}