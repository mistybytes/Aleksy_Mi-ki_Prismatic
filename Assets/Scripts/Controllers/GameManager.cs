using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private float shotSpeed = 5f; 
    private int coins = 0;
    private int collectedCoins = 0;
    private int bullet_damage = 10;
    private int enemy_health = 10;
    private int lives = 1;
    public float gameSpeed = 4f;
    private string currentSceneName = "";
    private float playerSpeed = 5f;
    private GameObject blasterType;
    
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

    }

    //blaster methods
    public void setBlasterType(GameObject blaster)
    {
        blasterType = blaster;
    }

    public GameObject getBlasterType()
    {
        return blasterType;
    }
    //methods for coins
    public void coinPickedUp()
    {
        collectedCoins++;
    }
    public string getCurrentScene()
    {
        return SceneManager.GetActiveScene().name;
    }
    public int getCollectedCoins()
    {
        return collectedCoins;
    }
    public int getCoins()
    {
        return coins;
    }
    //methods for player lives
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
    //player bullet methods
    public float getShotSpeed()
    {
        return shotSpeed;
    }
    public int getBulletDamage()
    {
        return bullet_damage;
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

    public void upgradeShotDamage()
    {
        bullet_damage += 5;
    }
    public void upgradeShotSpeed()
    {
        shotSpeed = shotSpeed - 0.5f;
    }

    public void upgradePlayerSpeed()
    {
        playerSpeed += 1;
    }
    public void levelEnded()
    {
        coins += collectedCoins;
        collectedCoins = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        {
            lives = 1;
            
            SceneManager.LoadScene("GameOver");
        }
    }
}
