using System;
using System.Threading;
using UnityEngine;

public class MyTimer : MonoBehaviour
{
   
    public static void CountUpTo1Minute()
    {
        int timeLimitInSeconds = 60;
        int elapsedTimeInSeconds = 0;

        //TODO do the listener in such a way that it doesnt freeze the game
        while (elapsedTimeInSeconds < timeLimitInSeconds)
        {
            Thread.Sleep(1); // Wait for 1 second
            elapsedTimeInSeconds++; // Increment elapsed time
        }

        // Raise the TimerElapsed event
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