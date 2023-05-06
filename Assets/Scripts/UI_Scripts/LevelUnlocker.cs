using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUnlocker : MonoBehaviour
{
    public GameObject level2Button;
    public GameObject level3Button;
    public GameObject level4Button;
    public GameObject level5Button;
    void Update()
    {
        // Check if level 1 has been completed
        if (LevelCompletionManager.instance.levelCompletionStatus[0])
        {
            // Enable access to level 2
            level2Button.SetActive(true);
        }
        else
        {
            // Disable access to level 2
            level2Button.SetActive(false);
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[1])
        {
            // Enable access to level 2
            level3Button.SetActive(true);
        }
        else
        {
            // Disable access to level 2
            level3Button.SetActive(false);
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[2])
        {
            // Enable access to level 2
            level4Button.SetActive(true);
        }
        else
        {
            // Disable access to level 2
            level4Button.SetActive(false);
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[3])
        {
            // Enable access to level 2
            level5Button.SetActive(true);
        }
        else
        {
            // Disable access to level 2
            level5Button.SetActive(false);
        }
    }
}
