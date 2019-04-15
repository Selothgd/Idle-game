using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExp : MonoBehaviour {

    public UnityEngine.UI.Text expDisplay;
    public float exp;
    public float expperkill;
    public int Level;
    public dmgup dmg;
    float cost = 10;
    int count;
    float baseCost = 10;

    void Update()
    {
        expDisplay.text = "Exp: " + exp + "\r\n" + "Exp to next level:" + cost;

        exp = PlayerPrefs.GetFloat("CurrentExp");
    }
    public void Killed()
    {
        exp += expperkill;
        PlayerPrefs.SetFloat("CurrentExp", exp);
    }

    public void LvlUp()
    {
        if(exp >= cost)
        {
            exp -= cost;
            count += 1;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.80f, count));
            dmg.hero1Dmg = dmg.hero1Dmg + 5;
            PlayerPrefs.SetFloat("CurrentExp", exp);
        }
    }
}
