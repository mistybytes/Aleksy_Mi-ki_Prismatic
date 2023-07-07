using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;
    
    //TODO add a field for current skin, know what type of field this will be
    private int currentLevel;
    
    private float shotSpeed = 3f; 
    private int coins = 100;
    private int collectedCoins;
    private int specialCurrency;
    private int bullet_damage = 10;
    private int enemy_health = 10;
    private int lives = 1;
    public float gameSpeed = 4f;
    
    
    private string currentSceneName = "";
    private float playerSpeed = 5f;

    public GameObject[] blasterList;
    
    public GameObject _classicalBlaster;
    public GameObject _iceBlaster;
    public GameObject _plasmaBlaster;
    public GameObject _transformationBlaster;
    public GameObject _lightBlaster;
    public GameObject _forceBlaster;
    public GameObject _voidBlaster;
    
    [SerializeField]
    private GameObject selectedBlaster;

    public void Save()
    {
        
        PlayerPrefs.SetString("classicalBlaster",_classicalBlaster.ToString());
        PlayerPrefs.SetString("iceBlaster",_iceBlaster.ToString());
        PlayerPrefs.SetString("plasmaBlaster",_plasmaBlaster.ToString());
        PlayerPrefs.SetString("transformationBlaster",_transformationBlaster.ToString());
        PlayerPrefs.SetString("lightBlaster",_lightBlaster.ToString());
        PlayerPrefs.SetString("forceBlaster",_forceBlaster.ToString());
        PlayerPrefs.SetString("voidBlaster",_voidBlaster.ToString());
        
        PlayerPrefs.SetInt("coins",coins);
        PlayerPrefs.SetInt("lives",lives);
        PlayerPrefs.SetInt("unlockedLevels",LevelCompletionManager.instance.getCurrentlyUnlocked());

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
        
        
        //TODO lives = PlayerPrefs.GetInt("lives");
        
        //TODO dodać życia jeszcze i ładowanie innych parametrów jak blaster
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
    public float getShotSpeed()
    {
        return shotSpeed;
    }
    public int getBulletDamage()
    {
        return bullet_damage;
    }

    public void setBulletDamage(int damage)
    {
        bullet_damage = damage;
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
