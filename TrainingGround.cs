using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TrainingGround : MonoBehaviour {


    public GameObject Enable_enemy;
    public GameObject Enable_battlespot;
    public GameObject Enable_floor;
    public FullEnemy Enemy1;
    public FullEnemy Enemy2;
    public FullEnemy Enemy3;
    public FullEnemy Enemy4;
    public FullEnemy Enemy5;
    public FullEnemy Enemy6;
    int a = 1;
    public Slider enemyhealthbar1;
    public Slider enemyhealthbar2;
    public Slider enemyhealthbar3;
    public Slider enemyhealthbar4;
    public Slider enemyhealthbar5;
    public Slider enemyhealthbar6;
    public Warrior health1;
    public Rouge health2;
    public Mage health3;
    public Priest health4;


    public void Enable()

    {
        enemyhealthbar1.value = Enemy1.startingHealth;
        Enemy1.currentHealth = Enemy1.startingHealth;

        enemyhealthbar2.value = Enemy2.startingHealth;
        Enemy2.currentHealth = Enemy2.startingHealth;

        enemyhealthbar3.value = Enemy3.startingHealth;
        Enemy3.currentHealth = Enemy3.startingHealth;

        enemyhealthbar4.value = Enemy4.startingHealth;
        Enemy4.currentHealth = Enemy4.startingHealth;

        enemyhealthbar5.value = Enemy5.startingHealth;
        Enemy5.currentHealth = Enemy5.startingHealth;

        enemyhealthbar6.value = Enemy6.startingHealth;
        Enemy6.currentHealth = Enemy6.startingHealth;

        if (a == 1)
        {
            Enable_enemy.SetActive(true);
        }
        if (a == 1)
        {
 //           Enemy1.isDead = false;
        }
        if (a == 1)
        {
            Enable_battlespot.SetActive(true);
            //            Enable_floor.GetComponent<Floor>().enabled = true;
            health1.GetComponent<Warrior>().enabled = true;
            health2.GetComponent<Rouge>().enabled = true;
            health3.GetComponent<Mage>().enabled = true;
            health4.GetComponent<Priest>().enabled = true;
        }
    }
}

  
