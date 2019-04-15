using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmgup : MonoBehaviour {

    public UnityEngine.UI.Text dmgUp;
    public Cash gold;
    public float cost;
    public float boostValue;
    public int count;
    private float baseCost;
    public float baseDmgInc;
    public float hero1Dmg = 10;

    void Awake()
    {
        baseCost = cost;
        gold.gold = PlayerPrefs.GetFloat("CurrentGold");
        hero1Dmg = PlayerPrefs.GetFloat("Hero1Dmg");
        cost = PlayerPrefs.GetFloat("Hero1Cost");
        boostValue = PlayerPrefs.GetFloat("Hero1BoostValue");
        count = PlayerPrefs.GetInt("Hero1count"); 

    }

    private void Update()
    {
        dmgUp.text = "Increase dmg by: " + boostValue + "\n Cost: " + cost;

    }

    public void damageUp()
    {

        if (gold.gold>= cost)
        {
            //   cash.gold -= cost;
            gold.gold -= cost;
            hero1Dmg = boostValue + hero1Dmg;
            count += 1;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.25f, count));
            boostValue = Mathf.Round(baseDmgInc * Mathf.Pow(1.15f, count));
            PlayerPrefs.SetFloat("CurrentGold", gold.gold);
            Debug.Log("Your current Dmg is: " + hero1Dmg);
            PlayerPrefs.SetFloat("Hero1Dmg", hero1Dmg);
            PlayerPrefs.SetFloat("Hero1Cost", cost);
            PlayerPrefs.SetFloat("Hero1BoostValue", boostValue);
            PlayerPrefs.SetInt("Hero1count", count);
        }
    }
}
