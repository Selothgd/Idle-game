using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hero1 : MonoBehaviour
{
    // public float CurrentHeroHealth1;
    //  public float MaxHero1Health;


    public void Hero_1()
    {
        SceneManager.LoadScene("Hero1");
    }
   void Start()
    {
    }

   /* private void Start()
    {
        MaxHero1Health = PlayerPrefs.GetFloat("MaxHero1Health");
        this.CurrentHeroHealth1 = this.MaxHero1Health;


    }
    void TakeDamage(int amount)
    {
        CurrentHeroHealth1 -= amount;
        PlayerPrefs.SetFloat("MaxHero1Health", MaxHero1Health);
        if (CurrentHeroHealth1 <= 0)
        {
            Die();
            Debug.Log("Hero1 Died");
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
    */
}
