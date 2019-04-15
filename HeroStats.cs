using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStats : MonoBehaviour
{

    public GameObject Enable_Disable;
    int a = 1;

    public void Enable()

    {
        if (a == 1)
        {
            Enable_Disable.SetActive(true);
            a += 1;
        }
        else
        {
            Enable_Disable.SetActive(false);
            a -= 1;
        }
    }
}