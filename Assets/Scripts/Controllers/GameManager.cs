using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private float shotSpeed = 3; 
    private int coins = 1;
    private int collectedCoins = 0;
    private int bullet_damage = 10;
    private int enemy_health = 10;
    private int lives = 1;
    public float gameSpeed = 4f;
    private string currentSceneName = "";
    
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

    public int getLives()
    {
        return lives;
    }
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
    public void AddLives()
    {
        lives++;
    }
    public void SubLives()
    {
        lives--;
    }
    public float getShotSpeed()
    {
        return shotSpeed;
    }
    public int getBulletDamage()
    {
        return bullet_damage;
    }

    public int getEnemyHealth()
    {
        return enemy_health;
    }

    public void levelEnded()
    {
        coins += collectedCoins;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 0)
        {
            levelEnded();
            lives = 1;
            SceneManager.LoadScene("GameOver");
        }

    }
}
