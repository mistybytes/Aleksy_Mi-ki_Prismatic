using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public ShopController sc;
    
    public Material playerSkin;
    
    public int currentLevel;
    
    
    
    private int coins;
    private int collectedCoins;
    private int specialCurrency;
    private int enemy_health;
    
    public int lives = 1;
    public float shotSpeed = 4f;
    public float speed = 5f;
    public int bulletDamage = 10;
    
    public float gameSpeed = 4f;
    
    private string currentSceneName = "";

    public GameObject[] blasterList;
    public Material[] unlockedSkins;
    public Material[] skins;
    
    public GameObject classicalBlaster;
    public GameObject plasmaBlaster;
    public GameObject iceBlaster;
    public GameObject transformationBlaster;
    public GameObject lightBlaster;
    public GameObject forceBlaster;
    public GameObject voidBlaster;

    public int classicalBlasterTimesUp;
    public int iceBlasterTimesUp;
    public int plasmaBlasterTimesUp;
    public int transformationBlasterTimesUp;
    public int lightBlasterTimesUp;
    public int forceBlasterTimesUp;
    public int voidBlasterTimesUp;

    public int classicalBlasterCost;
    public int plasmaBlasterCost;
    public int iceBlasterCost;
    public int transformationBlasterCost;
    public int lightBlasterCost;
    public int forceBlasterCost;
    public int voidBlasterCost;
    
    public GameObject selectedBlaster;

    public void Save()
    {
        PlayerPrefs.SetInt("classicalBlasterUpgraded",classicalBlasterTimesUp);
        PlayerPrefs.SetInt("iceBlasterUpgraded",iceBlasterTimesUp);
        PlayerPrefs.SetInt("plasmaBlasterUpgraded",plasmaBlasterTimesUp);
        PlayerPrefs.SetInt("transformationBlasterUpgraded",transformationBlasterTimesUp);
        PlayerPrefs.SetInt("lightBlasterUpgraded",lightBlasterTimesUp);
        PlayerPrefs.SetInt("forceBlasterUpgraded",forceBlasterTimesUp);
        PlayerPrefs.SetInt("voidBlasterUpgraded",voidBlasterTimesUp);
        
        PlayerPrefs.SetInt("classicalBlasterCost",classicalBlasterCost);
        PlayerPrefs.SetInt("iceBlasterCost",iceBlasterCost);
        PlayerPrefs.SetInt("plasmaBlasterCost",plasmaBlasterCost);
        PlayerPrefs.SetInt("transformationBlasterCost",transformationBlasterCost);
        PlayerPrefs.SetInt("lightBlasterCost",lightBlasterCost);
        PlayerPrefs.SetInt("forceBlasterCost",forceBlasterCost);
        PlayerPrefs.SetInt("voidBlasterCost",voidBlasterCost);
        
        PlayerPrefs.SetString("plasmaBlaster",plasmaBlaster.ToString());
        PlayerPrefs.SetString("iceBlaster",iceBlaster.ToString());
        PlayerPrefs.SetString("transformationBlaster",transformationBlaster.ToString());
        PlayerPrefs.SetString("lightBlaster",lightBlaster.ToString());
        PlayerPrefs.SetString("forceBlaster",forceBlaster.ToString());
        PlayerPrefs.SetString("voidBlaster",voidBlaster.ToString());
        
        PlayerPrefs.SetInt("coins",coins);
        PlayerPrefs.SetInt("currentlyUnlocked", LevelCompletionManager.instance.currentlyUnlocked);
        
    }
    void Awake()
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
        
        coins = PlayerPrefs.GetInt("coins");
        collectedCoins = 0;
    }

    private void Start()
    {
        PlayerPrefs.DeleteAll();

        classicalBlaster = blasterList[0];
        selectedBlaster = blasterList[0];
        
        BlasterVariables.instance.SetBlaster1Variables();
        
        classicalBlasterTimesUp = PlayerPrefs.GetInt("classicalBlasterUpgraded", 0);
        plasmaBlasterTimesUp = PlayerPrefs.GetInt("plasmaBlasterUpgraded", 0);
        iceBlasterTimesUp = PlayerPrefs.GetInt("iceBlasterUpgraded", 0);
        forceBlasterTimesUp = PlayerPrefs.GetInt("forceBlasterUpgraded", 0);
        lightBlasterTimesUp = PlayerPrefs.GetInt("lightBlasterUpgraded", 0);
        transformationBlasterTimesUp = PlayerPrefs.GetInt("transformationBlasterUpgraded", 0);
        voidBlasterTimesUp = PlayerPrefs.GetInt("voidBlasterUpgraded", 0);
        
        classicalBlasterCost = PlayerPrefs.GetInt("classicalBlasterCost",10);
        plasmaBlasterCost = PlayerPrefs.GetInt("plasmaBlasterCost", 50);
        iceBlasterCost = PlayerPrefs.GetInt("iceBlasterCost", 100);
        transformationBlasterCost = PlayerPrefs.GetInt("transformationBlasterCost", 200);
        lightBlasterCost = PlayerPrefs.GetInt("lightBlasterCost", 250);
        forceBlasterCost = PlayerPrefs.GetInt("forceBlasterCost", 300);
        voidBlasterCost = PlayerPrefs.GetInt("voidBlasterCost", 500);
        
        
        if (PlayerPrefs.GetString("plasmaBlaster") == "BLASTER2 (UnityEngine.GameObject)")
        {
            plasmaBlaster = blasterList[1];
        }
        if (PlayerPrefs.GetString("iceBlaster") == "BLASTER3 (UnityEngine.GameObject)" )
        { 
            iceBlaster = blasterList[2];
        }
        if (PlayerPrefs.GetString("transformationBlaster") == "BLASTER4 (UnityEngine.GameObject)")
        { 
            transformationBlaster = blasterList[3];
        }
        if (PlayerPrefs.GetString("lightBlaster") == "BLASTER5 (UnityEngine.GameObject)")
        { 
            lightBlaster = blasterList[4];
        }
        if (PlayerPrefs.GetString("forceBlaster") == "BLASTER6 (UnityEngine.GameObject)")
        { 
            forceBlaster = blasterList[5];
        }
        if (PlayerPrefs.GetString("voidBlaster") == "BLASTER7 (UnityEngine.GameObject)")
        { 
            voidBlaster = blasterList[6];
        }
        
        currentLevel = PlayerPrefs.GetInt("currentlyUnlocked", 40);

    }
    
    //speed variables
    public void setShotSpeed(float s)
    {
        
        shotSpeed = s;
    }
    public void setSpeed(float s)
    {
        
        speed = s;
    }

    public float getShotSpeed()
    {
        Debug.Log(shotSpeed);
        return shotSpeed;
    }
    public float getSpeed()
    {
        Debug.Log(speed);
        return speed;
    }
    //blaster methods
    public void setBlasterType(GameObject blaster)
    {
        selectedBlaster = blaster;
    }

    public void EnemyKilled()
    {
        collectedCoins += 3;
    }
    //methods for coins
    public void coinPickedUp()
    {
        collectedCoins += 6;
    }
    public int getCollectedCoins()
    {
        return collectedCoins;
    }
    public ref int getCoins()
    {
        return ref coins;
    }
    public void setCoins(int i)
    {
        coins = i;
    }
    
    public int getLives()
    {
        return lives;
    }
    public void AddLives()
    {
        lives++;
    }
    
    public void SubLives()
    {
        lives--;
    }

    public void setLives(int l)
    {
        lives = l;
    }
    //player bullet methods
    public float getEnemyShotSpeed()
    {
        return shotSpeed;
    }
    
    //enemy script
    public int getEnemyHealth()
    {
        return enemy_health;
    }

    public void setEnemyHealth(int health)
    {
        enemy_health = health;
    }
    public void levelEnded()
    {
        coins += collectedCoins;
        collectedCoins = 0;
    }
    public void setCurrentLevel(int l)
    {
        currentLevel = l;
    }
    
    void Update()
    {
        if (lives <= 0)
        {
            lives = 1;
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
            SceneManager.LoadScene("GameOver");
        }
    }
}
