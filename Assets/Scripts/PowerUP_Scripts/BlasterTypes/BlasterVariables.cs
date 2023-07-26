using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterVariables : MonoBehaviour
{
    public float playerSpeed;
    public int playerLives;
    public float shotSpeed;
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
