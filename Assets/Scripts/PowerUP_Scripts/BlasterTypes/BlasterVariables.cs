using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterVariables : MonoBehaviour
{
    public float blaster1PlayerSpeed;
    public int blaster1PlayerLives;
    public float blaster1ShotSpeed;
    public float blaster1Damage;
    
    public float blaster2PlayerSpeed;
    public int blaster2PlayerLives;
    public float blaster2ShotSpeed;
    public float blaster2Damage;

    public float blaster3PlayerSpeed;
    public int blaster3PlayerLives;
    public float blaster3ShotSpeed;
    public float blaster3Damage;
    
    public float blaster4PlayerSpeed;
    public int blaster4PlayerLives;
    public float blaster4ShotSpeed;
    public float blaster4Damage;

    public float blaster5PlayerSpeed;
    public int blaster5PlayerLives;
    public float blaster5ShotSpeed;
    public float blaster5Damage;

    public float blaster6PlayerSpeed;
    public int blaster6PlayerLives;
    public float blaster6ShotSpeed;
    public float blaster6Damage;

    public float blaster7PlayerSpeed;
    public int blaster7PlayerLives;
    public float blaster7ShotSpeed;
    public float blaster7Damage;

    
    public static BlasterVariables instance;
    public void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }

        blaster1Damage = PlayerPrefs.GetFloat("blaster1Damage", 10);
        blaster1ShotSpeed = PlayerPrefs.GetFloat("blaster1ShotSpeed", 4);
        blaster1PlayerLives = PlayerPrefs.GetInt("blaster1PlayerLives", 1);
        blaster1PlayerSpeed = PlayerPrefs.GetFloat("blaster1PlayerSpeed", 4);
        
        blaster2Damage = PlayerPrefs.GetFloat("blaster1Damage", 10);
        blaster2ShotSpeed = PlayerPrefs.GetFloat("blaster1ShotSpeed", 4);
        blaster2PlayerLives = PlayerPrefs.GetInt("blaster1PlayerLives", 1);
        blaster2PlayerSpeed = PlayerPrefs.GetFloat("blaster1PlayerSpeed", 4);
        
        blaster3Damage = PlayerPrefs.GetFloat("blaster1Damage", 10);
        blaster3ShotSpeed = PlayerPrefs.GetFloat("blaster1ShotSpeed", 4);
        blaster3PlayerLives = PlayerPrefs.GetInt("blaster1PlayerLives", 1);
        blaster3PlayerSpeed = PlayerPrefs.GetFloat("blaster1PlayerSpeed", 4);
        
        blaster4Damage = PlayerPrefs.GetFloat("blaster1Damage", 10);
        blaster4ShotSpeed = PlayerPrefs.GetFloat("blaster1ShotSpeed", 4);
        blaster4PlayerLives = PlayerPrefs.GetInt("blaster1PlayerLives", 1);
        blaster4PlayerSpeed = PlayerPrefs.GetFloat("blaster1PlayerSpeed", 4);
        
        blaster5Damage = PlayerPrefs.GetFloat("blaster1Damage", 10);
        blaster5ShotSpeed = PlayerPrefs.GetFloat("blaster1ShotSpeed", 4);
        blaster5PlayerLives = PlayerPrefs.GetInt("blaster1PlayerLives", 1);
        blaster5PlayerSpeed = PlayerPrefs.GetFloat("blaster1PlayerSpeed", 4);
        
        blaster6Damage = PlayerPrefs.GetFloat("blaster1Damage", 10);
        blaster6ShotSpeed = PlayerPrefs.GetFloat("blaster1ShotSpeed", 4);
        blaster6PlayerLives = PlayerPrefs.GetInt("blaster1PlayerLives", 1);
        blaster6PlayerSpeed = PlayerPrefs.GetFloat("blaster1PlayerSpeed", 4);
        
        blaster7Damage = PlayerPrefs.GetFloat("blaster1Damage", 10);
        blaster7ShotSpeed = PlayerPrefs.GetFloat("blaster1ShotSpeed", 4);
        blaster7PlayerLives = PlayerPrefs.GetInt("blaster1PlayerLives", 1);
        blaster7PlayerSpeed = PlayerPrefs.GetFloat("blaster1PlayerSpeed", 4);
        
    }

    public void setVariables()
    {
       
    }

    public void SetBlaster2Variables()
    {
        
    }
    public void SetBlaster3Variables()
    {
        
    }
    public void SetBlaster4Variables()
    {
        
    }
    public void SetBlaster5Variables()
    {
        
    }
    public void SetBlaster6Variables()
    {
        
    }
    public void SetBlaster7Variables()
    {
        
    }
    public void upgradeBlasterVariables(float s,float ss, int l)
    {
     
        
        
    }

    public void UpgradeBlaster2Variables(float s, float ss, int l, int dmg)
    {
        
    }
    public void UpgradeBlaster3Variables(float s, float ss, int l, int dmg)
    {
        
    }
    public void UpgradeBlaster4Variables(float s, float ss, int l, int dmg)
    {
        
    }
    public void UpgradeBlaster5Variables(float s, float ss, int l, int dmg)
    {
        
    }
    public void UpgradeBlaster6Variables(float s, float ss, int l, int dmg)
    {
        
    }
    public void UpgradeBlaster7Variables(float s, float ss, int l, int dmg)
    {
        
    }
}
