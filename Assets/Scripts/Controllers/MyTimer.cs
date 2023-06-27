using System;
using System.Collections;
using System.Threading;
using UnityEngine;

public class MyTimer : MonoBehaviour
{
    static public IEnumerator CountUpTo1Minute()
    {
        yield return new WaitForSeconds(6);
       
        OnTimerElapsed();
    }
    
    private static void OnTimerElapsed()
    {
        /**
         * method for unlocking levels based on the current level
         */
        if (!LevelCompletionManager.instance.levelCompletionStatus[GameManager.instance.getCurrenLevel()])
        {
            LevelCompletionManager.instance.levelCompletionStatus[GameManager.instance.getCurrenLevel()] = true;
        }
    }

}