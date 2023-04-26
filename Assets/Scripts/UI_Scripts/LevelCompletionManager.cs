using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompletionManager : MonoBehaviour
{
    public static LevelCompletionManager instance;

    public bool[] levelCompletionStatus;

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

        levelCompletionStatus = new bool[4]; 
        levelCompletionStatus[0] = false;
        levelCompletionStatus[1] = false;
        levelCompletionStatus[2] = false;
        levelCompletionStatus[3] = false;
    }
}
