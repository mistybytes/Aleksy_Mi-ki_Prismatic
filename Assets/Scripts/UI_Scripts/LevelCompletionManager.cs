using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompletionManager : MonoBehaviour
{
    public static LevelCompletionManager instance;
    public int currentlyUnlocked;
    private bool[] levelCompletionStatus = new bool[48];

   
    void Start()
    {

        if (instance == null)
        {
            
            for (int i = 0; i < 48; i++)
            {
                levelCompletionStatus[i] = false;
            }
            
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        currentlyUnlocked = GameManager.instance.currentLevel;

        for (var i = 0; i < currentlyUnlocked; i++)
        {
            levelCompletionStatus[i] = true;
        }
        
    }
    
    public bool[] getLevelCompletionStatus()
    {
        return levelCompletionStatus;
    }

    public void setLevelCompletionStatus(int i)
    {
        currentlyUnlocked++;
        levelCompletionStatus[i] = true;
    }

    public int getCurrentlyUnlocked()
    {
        return currentlyUnlocked;
    }
}
