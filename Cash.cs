using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cash : MonoBehaviour {

    public UnityEngine.UI.Text goldDisplay;
    public float goldperkill;
    public float gold;


    void Update()
    {
        goldDisplay.text = "Gold: " + gold;
        gold = PlayerPrefs.GetFloat("CurrentGold");
    }

    public void Killed()
    {
        gold += goldperkill;
        PlayerPrefs.SetFloat("CurrentGold", gold);
    }
	
}
