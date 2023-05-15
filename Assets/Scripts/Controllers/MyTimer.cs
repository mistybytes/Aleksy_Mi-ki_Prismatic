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

        if (k >= 7 && k<= 15 && GameManager.instance.getCurrentScene() == "TYPE1BOSS")
        {
            LevelCompletionManager.instance.levelCompletionStatus[k] = true;
            k++;
        }
        //TODO dokończ, idea jest zajebista na odblokowywanie
        //I PÓŹNIEJSZY ZAPIS
    }
    public void  setK(int setter)
    {
        k = setter;
    }
    public static ref int getK()
    {
        return ref k;
    }
}