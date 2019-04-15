using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Floor : MonoBehaviour {
    public Text CurrentFloor;
    public Text KillCount;
    public float currentFloor = 1;
    public float maxFloor = 1;
    public GameObject FloorUpButton;
    public GameObject AutoAdvanceText;
    public EnemyManager enemy;
    int b = 1;
    public FullEnemy enemy1;
    public FullEnemy enemy2;
    public FullEnemy enemy3;
    public FullEnemy enemy4;
    public FullEnemy enemy5;
    public FullEnemy enemy6;
    /*
*/
public void Update()
    {
        CurrentFloor.text = currentFloor + "/" + maxFloor;
        KillCount.text = "Kills untill Floor UP " + "\n" + enemy.killCount + " / 50";
        autoAdvance();
        if (enemy.killCount >= 50)
        {
            enemy.killCount = 0;
            maxFloor = maxFloor + 1;
        }
        if (currentFloor == maxFloor)
        {
            FloorUpButton.SetActive(false);
        }
        else
        {
            FloorUpButton.SetActive(true);
        }




    }
    public void FloorUp()
    {
        if (currentFloor < maxFloor)
        {
            currentFloor = currentFloor + 1;
        }
    }
    public void FloorDown()
    {
        if(currentFloor == 1)
        {
            return;
        }
        else
        {
            currentFloor = currentFloor - 1;
        }

    }
    public void autoAdvance()
    {
        if (b == 1)
        {
            currentFloor = maxFloor;
        }

    }
    public void autoAdvanceButton()
    {
        if (b == 1)
        {
            b++;
            AutoAdvanceText.SetActive(false);
        }
        else
        {
            b--;
            AutoAdvanceText.SetActive(true);
        }
    }
}
