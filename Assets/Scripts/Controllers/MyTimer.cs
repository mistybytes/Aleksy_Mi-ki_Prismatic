using System;
using System.Collections;
using System.Threading;
using UnityEngine;

public class MyTimer : MonoBehaviour
{
    private static int k = 0;
    static public IEnumerator CountUpTo1Minute()
    {
        yield return new WaitForSeconds(6);
       
        OnTimerElapsed();
    }
   
    private static void OnTimerElapsed()
    {
        if (GameManager.instance.getCurrentScene() == "LEVEL1")
        {
            LevelCompletionManager.instance.levelCompletionStatus[k] = true;
            k++;
        }
    }
    
}