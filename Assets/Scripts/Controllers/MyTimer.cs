using System;
using System.Collections;
using System.Threading;
using UnityEngine;

public class MyTimer : MonoBehaviour
{

    static public IEnumerator CountUpTo1Minute()
    {
        yield return new WaitForSeconds(60);
        OnTimerElapsed();
    }
   
    protected static void OnTimerElapsed()
    {
        Debug.Log(GameManager.instance.getCurrentScene());
        if (GameManager.instance.getCurrentScene() == "LEVEL1") LevelCompletionManager.instance.levelCompletionStatus[0] = true;
        if (GameManager.instance.getCurrentScene() == "LEVEL2") LevelCompletionManager.instance.levelCompletionStatus[1] = true;
        if (GameManager.instance.getCurrentScene() == "LEVEL3") LevelCompletionManager.instance.levelCompletionStatus[2] = true;
        if (GameManager.instance.getCurrentScene() == "LEVEL4") LevelCompletionManager.instance.levelCompletionStatus[3] = true;
    }
}