using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterVariables : MonoBehaviour
{
    //TODO remove the blaster variables script from the Blasters and make is so that it is held by a different object that i can instantiate eralier
    private float playerSpeed = 1f;
    private int playerLives = 1;
    private float shotSpeed = 4f;
    
    public void Start()
    {
        Debug.Log("Blaster variables is created and the values are as such:\nplayer speed: " + playerSpeed +"\nplayer lives: " + playerLives + "\nshot speed: " + shotSpeed);
        
        setVariables();
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
        Debug.Log(shotSpeed);
        playerSpeed += s;
        playerLives += l;
        
        setVariables();
    }
}
