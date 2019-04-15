using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

    public UnityEngine.UI.Text killInfo;
    public bool kill;
    public float goldperkill;
    public int count;
    public float gold;

    public void KilledMonster()
    {
        if(kill == true)
        {
            gold += goldperkill;
        }
    }
}
