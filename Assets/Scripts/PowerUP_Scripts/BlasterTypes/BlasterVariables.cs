using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterVariables : MonoBehaviour
{
    public float playerSpeed;
    public int playerLives;
    public float shotSpeed;

    public void Start()
    {
        switch (GameManager.instance.selectedBlaster.ToString())
        {
            case "Blaster1":
                for (int i = 0; i < GameManager.instance.classicalBlasterTimesUp; i++)
                {
                    if(i == 0)
                        upgradeBlasterVariables(0.2f,0.5f,1);
                }
                break;
                
        }
    }

    public void setVariables()
    {
        GameManager.instance.setSpeed(playerSpeed);
        GameManager.instance.setLives(playerLives);
        GameManager.instance.setShotSpeed(shotSpeed);
    }

    public void upgradeBlasterVariables(float s,float ss, int l)
    {
        shotSpeed -= ss;
        playerSpeed += s;
        playerLives += l;
    }
}
