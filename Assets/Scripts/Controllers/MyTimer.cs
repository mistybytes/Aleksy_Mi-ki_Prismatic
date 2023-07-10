using System;
using System.Collections;
using System.Threading;
using UnityEngine;

public class MyTimer : MonoBehaviour
{
    static public IEnumerator CountUpTo1Minute()
    {
        yield return new WaitForSeconds(60);
        
        if (!LevelCompletionManager.instance.getLevelCompletionStatus()[GameManager.instance.getCurrenLevel()])
        {
            LevelCompletionManager.instance.setLevelCompletionStatus(GameManager.instance.getCurrenLevel());
        }
    }
}