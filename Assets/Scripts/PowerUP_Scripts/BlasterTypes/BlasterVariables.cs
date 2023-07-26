using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterVariables : MonoBehaviour
{
    public PlayerMovement player;
    public float playerSpeed;
    public int playerLives;

    public void setVariables()
    {
        GameManager.instance.setSpeed(playerSpeed);
        GameManager.instance.setLives(playerLives);
    }

    public void upgradeBlasterVariables(float s, int l)
    {
        playerSpeed += s;
        playerLives += l;
    }
}
