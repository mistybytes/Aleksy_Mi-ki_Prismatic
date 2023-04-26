using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int lives = 3;
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

    public string getCurrentScene()
    {
        return SceneManager.GetActiveScene().name;
    }

    public void AddLives()
    {
        lives++;
    }
    public void SubLives()
    {
        lives--;
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
            lives = 3;
            SceneManager.LoadScene("MainMenu");
        }

    }
}
