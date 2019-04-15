using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public float gold = 10.00f;
    public float hero1Dmg;
    public float cost;
    public float boostValue;
    public int count;
    public float MaxHero1Health;
    public float Exp;

    public void PlayGame()
    {
        PlayerPrefs.SetFloat("CurrentGold", gold);
        PlayerPrefs.SetFloat("Hero1Dmg", hero1Dmg);
        PlayerPrefs.SetFloat("Hero1Cost", cost);
        PlayerPrefs.SetFloat("Hero1BoostValue", boostValue);
        PlayerPrefs.SetInt("Hero1count", count);
        PlayerPrefs.SetFloat("MaxHero1Health", MaxHero1Health); 
        SceneManager.LoadScene("Game");
        PlayerPrefs.SetFloat("CurrentExp", Exp);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
