using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompletionManager : MonoBehaviour
{
    public static LevelCompletionManager instance;

    public bool[] levelCompletionStatus;

    void Start()
    {
        if (instance == null)
        {
            levelCompletionStatus = new bool[6];
            levelCompletionStatus[0] = false;
            levelCompletionStatus[1] = false;
            levelCompletionStatus[2] = false;
            levelCompletionStatus[3] = false;
            levelCompletionStatus[4] = false;
            levelCompletionStatus[5] = false;
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

       
       
    }
}
