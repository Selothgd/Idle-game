using UnityEngine;

public class HeroAttack : MonoBehaviour
{
    public dmgup dmg;
    //public float damagePerHit;                  // The damage inflicted by each bullet.
    public float timeBetweenHits;        // The time between each shot.
    public PlayerExp level;

    FullEnemy enemyHealthBar;
    HealthBar healthbar;
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


    private void Awake()
    {
        int rnd = Random.Range(1, 3);
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
        }
        healthbar = GetComponent<HealthBar>();
    }
    void Update()
    {
        // Add the time since Update was last called to the timer.
        timer += Time.deltaTime;
        level.LvlUp();
        if (timer >= timeBetweenHits && healthbar.currentHealth > 0 && enemyHealthBar.isDead == false)
        {
            // ... attack.
            Attack();
        }
    }

    void Attack()
    {
        // Reset the timer.
        timer = 0f;
        int rnd = Random.Range(1, 3);
        if (healthbar.currentHealth > 0 && enemyHealthBar.isDead == false)
        {
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
            }
        }
            // ... damage the player.
            enemyHealthBar.TakeDamage(dmg.hero1Dmg);
    }
}