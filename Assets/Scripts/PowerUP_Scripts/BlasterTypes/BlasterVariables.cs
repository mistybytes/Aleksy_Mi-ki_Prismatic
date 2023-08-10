using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterVariables : MonoBehaviour
{
    public static BlasterVariables instance;

    public float blaster1PlayerSpeed;
    public int blaster1PlayerLives;
    public float blaster1ShotSpeed;
    public int blaster1Damage;
    
    public float blaster2PlayerSpeed;
    public int blaster2PlayerLives;
    public float blaster2ShotSpeed;
    public int blaster2Damage;

    public float blaster3PlayerSpeed;
    public int blaster3PlayerLives;
    public float blaster3ShotSpeed;
    public int blaster3Damage;
    
    public float blaster4PlayerSpeed;
    public int blaster4PlayerLives;
    public float blaster4ShotSpeed;
    public int blaster4Damage;

    public float blaster5PlayerSpeed;
    public int blaster5PlayerLives;
    public float blaster5ShotSpeed;
    public int blaster5Damage;

    public float blaster6PlayerSpeed;
    public int blaster6PlayerLives;
    public float blaster6ShotSpeed;
    public int blaster6Damage;

    public float blaster7PlayerSpeed;
    public int blaster7PlayerLives;
    public float blaster7ShotSpeed;
    public int blaster7Damage;
    
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

        blaster1Damage = PlayerPrefs.GetInt("blaster1Damage", 10);
        blaster1ShotSpeed = PlayerPrefs.GetFloat("blaster1ShotSpeed", 4);
        blaster1PlayerLives = PlayerPrefs.GetInt("blaster1PlayerLives", 1);
        blaster1PlayerSpeed = PlayerPrefs.GetFloat("blaster1PlayerSpeed", 2);
        
        blaster2Damage = PlayerPrefs.GetInt("blaster2Damage", 10);
        blaster2ShotSpeed = PlayerPrefs.GetFloat("blaster2ShotSpeed", 4);
        blaster2PlayerLives = PlayerPrefs.GetInt("blaster2PlayerLives", 1);
        blaster2PlayerSpeed = PlayerPrefs.GetFloat("blaster2PlayerSpeed", 4);
        
        blaster3Damage = PlayerPrefs.GetInt("blaster3Damage", 10);
        blaster3ShotSpeed = PlayerPrefs.GetFloat("blaster3ShotSpeed", 4);
        blaster3PlayerLives = PlayerPrefs.GetInt("blaster3PlayerLives", 1);
        blaster3PlayerSpeed = PlayerPrefs.GetFloat("blaster3PlayerSpeed", 4);
        
        blaster4Damage = PlayerPrefs.GetInt("blaster4Damage", 10);
        blaster4ShotSpeed = PlayerPrefs.GetFloat("blaster4ShotSpeed", 4);
        blaster4PlayerLives = PlayerPrefs.GetInt("blaster4PlayerLives", 1);
        blaster4PlayerSpeed = PlayerPrefs.GetFloat("blaster4PlayerSpeed", 4);
        
        blaster5Damage = PlayerPrefs.GetInt("blaster5Damage", 10);
        blaster5ShotSpeed = PlayerPrefs.GetFloat("blaster5ShotSpeed", 4);
        blaster5PlayerLives = PlayerPrefs.GetInt("blaster5PlayerLives", 1);
        blaster5PlayerSpeed = PlayerPrefs.GetFloat("blaster5PlayerSpeed", 4);
        
        blaster6Damage = PlayerPrefs.GetInt("blaster6Damage", 10);
        blaster6ShotSpeed = PlayerPrefs.GetFloat("blaster6ShotSpeed", 4);
        blaster6PlayerLives = PlayerPrefs.GetInt("blaster6PlayerLives", 1);
        blaster6PlayerSpeed = PlayerPrefs.GetFloat("blaster6PlayerSpeed", 4);
        
        blaster7Damage = PlayerPrefs.GetInt("blaster7Damage", 10);
        blaster7ShotSpeed = PlayerPrefs.GetFloat("blaster7ShotSpeed", 4);
        blaster7PlayerLives = PlayerPrefs.GetInt("blaster7PlayerLives", 1);
        blaster7PlayerSpeed = PlayerPrefs.GetFloat("blaster7PlayerSpeed", 4);
        
    }

    public void SetBlaster1Variables()
    {
        GameManager.instance.speed = blaster1PlayerSpeed;
        GameManager.instance.shotSpeed = blaster1ShotSpeed;
        GameManager.instance.lives = blaster1PlayerLives;
        GameManager.instance.bulletDamage = blaster1Damage;
    }

    public void SetBlaster2Variables()
    {
        GameManager.instance.speed = blaster2PlayerSpeed;
        GameManager.instance.shotSpeed = blaster2ShotSpeed;
        GameManager.instance.lives = blaster2PlayerLives;
        GameManager.instance.bulletDamage = blaster2Damage;
    }
    public void SetBlaster3Variables()
    {
        GameManager.instance.speed = blaster3PlayerSpeed;
        GameManager.instance.shotSpeed = blaster3ShotSpeed;
        GameManager.instance.lives = blaster3PlayerLives;
        GameManager.instance.bulletDamage = blaster3Damage;
    }
    public void SetBlaster4Variables()
    {
        GameManager.instance.speed = blaster4PlayerSpeed;
        GameManager.instance.shotSpeed = blaster4ShotSpeed;
        GameManager.instance.lives = blaster4PlayerLives;
        GameManager.instance.bulletDamage = blaster4Damage;
    }
    public void SetBlaster5Variables()
    {
        GameManager.instance.speed = blaster5PlayerSpeed;
        GameManager.instance.shotSpeed = blaster5ShotSpeed;
        GameManager.instance.lives = blaster5PlayerLives;
        GameManager.instance.bulletDamage = blaster5Damage;
    }
    public void SetBlaster6Variables()
    {
        GameManager.instance.speed = blaster6PlayerSpeed;
        GameManager.instance.shotSpeed = blaster6ShotSpeed;
        GameManager.instance.lives = blaster6PlayerLives;
        GameManager.instance.bulletDamage = blaster6Damage;
    }
    public void SetBlaster7Variables()
    {
        GameManager.instance.speed = blaster7PlayerSpeed;
        GameManager.instance.shotSpeed = blaster7ShotSpeed;
        GameManager.instance.lives = blaster7PlayerLives;
        GameManager.instance.bulletDamage = blaster7Damage;
    }
    public void UpgradeBlaster1Variables(float s, float ss, int l, int dmg)
    {
        blaster1PlayerSpeed = s;
        blaster1ShotSpeed = ss;
        blaster1PlayerLives = l;
        blaster1Damage = dmg;
        
        PlayerPrefs.SetFloat("blaster1PlayerSpeed", blaster1PlayerSpeed);
        PlayerPrefs.SetFloat("blaster1ShotSpeed",blaster1ShotSpeed);
        PlayerPrefs.SetInt("blaster1PlayerLives",blaster1PlayerLives);
        PlayerPrefs.SetInt("blaster1Damage",blaster1Damage);


    }

    public void UpgradeBlaster2Variables(float s, float ss, int l, int dmg)
    {
        blaster2PlayerSpeed = s;
        blaster2ShotSpeed = ss;
        blaster2PlayerLives = l;
        blaster2Damage = dmg;
        
        PlayerPrefs.SetFloat("blaster1PlayerSpeed", blaster1PlayerSpeed);
        PlayerPrefs.SetFloat("blaster1ShotSpeed",blaster1ShotSpeed);
        PlayerPrefs.SetInt("blaster1PlayerLives",blaster1PlayerLives);
        PlayerPrefs.SetInt("blaster1Damage",blaster1Damage);
    }
    public void UpgradeBlaster3Variables(float s, float ss, int l, int dmg)
    {
        blaster3PlayerSpeed = s;
        blaster3ShotSpeed = ss;
        blaster3PlayerLives = l;
        blaster3Damage = dmg;
        
        PlayerPrefs.SetFloat("blaster1PlayerSpeed", blaster1PlayerSpeed);
        PlayerPrefs.SetFloat("blaster1ShotSpeed",blaster1ShotSpeed);
        PlayerPrefs.SetInt("blaster1PlayerLives",blaster1PlayerLives);
        PlayerPrefs.SetInt("blaster1Damage",blaster1Damage);
    }
    public void UpgradeBlaster4Variables(float s, float ss, int l, int dmg)
    {
        blaster4PlayerSpeed = s;
        blaster4ShotSpeed = ss;
        blaster4PlayerLives = l;
        blaster4Damage = dmg;
        
        PlayerPrefs.SetFloat("blaster1PlayerSpeed", blaster1PlayerSpeed);
        PlayerPrefs.SetFloat("blaster1ShotSpeed",blaster1ShotSpeed);
        PlayerPrefs.SetInt("blaster1PlayerLives",blaster1PlayerLives);
        PlayerPrefs.SetInt("blaster1Damage",blaster1Damage);
    }
    public void UpgradeBlaster5Variables(float s, float ss, int l, int dmg)
    {
        blaster5PlayerSpeed = s;
        blaster5ShotSpeed = ss;
        blaster5PlayerLives = l;
        blaster5Damage = dmg;
        
        PlayerPrefs.SetFloat("blaster1PlayerSpeed", blaster1PlayerSpeed);
        PlayerPrefs.SetFloat("blaster1ShotSpeed",blaster1ShotSpeed);
        PlayerPrefs.SetInt("blaster1PlayerLives",blaster1PlayerLives);
        PlayerPrefs.SetInt("blaster1Damage",blaster1Damage);
    }
    public void UpgradeBlaster6Variables(float s, float ss, int l, int dmg)
    {
        blaster6PlayerSpeed = s;
        blaster6ShotSpeed = ss;
        blaster6PlayerLives = l;
        blaster6Damage = dmg;
        
        PlayerPrefs.SetFloat("blaster1PlayerSpeed", blaster1PlayerSpeed);
        PlayerPrefs.SetFloat("blaster1ShotSpeed",blaster1ShotSpeed);
        PlayerPrefs.SetInt("blaster1PlayerLives",blaster1PlayerLives);
        PlayerPrefs.SetInt("blaster1Damage",blaster1Damage);
    }
    public void UpgradeBlaster7Variables(float s, float ss, int l, int dmg)
    {
        blaster7PlayerSpeed = s;
        blaster7ShotSpeed = ss;
        blaster7PlayerLives = l;
        blaster7Damage = dmg;
        
        PlayerPrefs.SetFloat("blaster1PlayerSpeed", blaster1PlayerSpeed);
        PlayerPrefs.SetFloat("blaster1ShotSpeed",blaster1ShotSpeed);
        PlayerPrefs.SetInt("blaster1PlayerLives",blaster1PlayerLives);
        PlayerPrefs.SetInt("blaster1Damage",blaster1Damage);
    }
}
