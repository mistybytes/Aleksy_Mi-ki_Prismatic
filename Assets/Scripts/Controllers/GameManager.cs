using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;

    public Material playerSkin;
    
    [SerializeField]
    private ShopController sc;
    
    private int currentLevel;
    
    private float shotSpeed = 3f;
    
    private int coins = 100;
    private int collectedCoins;
    private int specialCurrency;
    private int enemy_health = 10;
    private int lives = 1;
    
    private float speed = 2f;
    public float gameSpeed = 4f;
    
    private string currentSceneName = "";
    private float playerSpeed = 5f;

    public GameObject[] blasterList;
    public Material[] unlockedSkins;
    public Material[] skins;
    public GameObject _classicalBlaster;
    public GameObject _iceBlaster;
    public GameObject _plasmaBlaster;
    public GameObject _transformationBlaster;
    public GameObject _lightBlaster;
    public GameObject _forceBlaster;
    public GameObject _voidBlaster;
    
    public GameObject selectedBlaster;

    public void Save()
    {
        PlayerPrefs.SetString("plasmaBlaster",_plasmaBlaster.ToString());
        PlayerPrefs.SetString("iceBlaster",_iceBlaster.ToString());
        PlayerPrefs.SetString("transformationBlaster",_transformationBlaster.ToString());
        PlayerPrefs.SetString("lightBlaster",_lightBlaster.ToString());
        PlayerPrefs.SetString("forceBlaster",_forceBlaster.ToString());
        PlayerPrefs.SetString("voidBlaster",_voidBlaster.ToString());
        
        PlayerPrefs.SetInt("coins",coins);
        PlayerPrefs.SetInt("lives",lives);
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
        
        lives = PlayerPrefs.GetInt("lives", defaultValue: 1);
        
        //TODO dodać ładowanie innych parametrów jak blaster
    }

    private void Start()
    {
        
        _classicalBlaster = blasterList[0];
        
        if (PlayerPrefs.GetString("iceBlaster") != null)
        { 
            _iceBlaster = blasterList[1];
        }
        if (PlayerPrefs.GetString("plasmaBlaster") != null )
        { 
            _plasmaBlaster = blasterList[2];
        }
        if (PlayerPrefs.GetString("transformationBlaster") != null)
        { 
            _transformationBlaster = blasterList[3];
        }
        if (PlayerPrefs.GetString("lightBlaster") != null)
        { 
            _lightBlaster = blasterList[4];
        }
        if (PlayerPrefs.GetString("forceBlaster") != null)
        { 
            _forceBlaster = blasterList[5];
        }
        if (PlayerPrefs.GetString("voidBlaster") != null)
        { 
            _voidBlaster = blasterList[6];
        }
        

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
        return shotSpeed;
    }
    public float getSpeed()
    {
        return speed;
    }
    //blaster methods
    public void setBlasterType(GameObject blaster)
    {
        selectedBlaster = blaster;
    }

    public GameObject getBlasterType()
    {
        return selectedBlaster;
    }
    //methods for coins
    public void coinPickedUp()
    {
        collectedCoins++;
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
    
    //methods for special currency
    
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

    public int getCurrenLevel()
    {
        return currentLevel;
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
