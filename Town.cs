using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Town : MonoBehaviour
{
    public Slider healthbar1;
    public Slider healthbar2;
    public Slider healthbar3;
    public Slider healthbar4;
    public GameObject Disable_enemy;
    public GameObject Disable_battlespot;
    public GameObject Disable_floor; 
   int a = 1;
    public Warrior health1;
    public Rouge health2;
    public Mage health3;
    public Priest health4;
    public FullEnemy Enemy1;
    public FullEnemy Enemy2;
    public FullEnemy Enemy3;
    public FullEnemy Enemy4;
    public FullEnemy Enemy5;
    public FullEnemy Enemy6;


    public void Enable()

    {
        healthbar1.value = health1.startingHealth;
        health1.currentHealth = health1.startingHealth;

        healthbar2.value = health2.startingHealth;
        health2.currentHealth = health2.startingHealth;

        healthbar3.value = health3.startingHealth;
        health3.currentHealth = health3.startingHealth;

        healthbar4.value = health4.startingHealth;
        health4.currentHealth = health4.startingHealth;

        if (a == 1)
        {
            Disable_enemy.SetActive(false);
        }
        if (a == 1)
        {
            Disable_battlespot.SetActive(false);
            /*           Enemy1.isDead = true;
                       Enemy2.isDead = true;
                       Enemy3.isDead = true;
                       Enemy4.isDead = true;
                       Enemy5.isDead = true;
                       Enemy6.isDead = true; */
            //            Disable_floor.GetComponent<Floor>().enabled = true;
           health1.GetComponent<Warrior>().enabled = false;
            health2.GetComponent<Rouge>().enabled = false;
            health3.GetComponent<Mage>().enabled = false;
            health4.GetComponent<Priest>().enabled = false;
        }
    }
    }