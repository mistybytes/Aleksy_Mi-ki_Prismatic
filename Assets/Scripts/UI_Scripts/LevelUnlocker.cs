using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocker : MonoBehaviour
{
    public Button level2Button;
    public Button level3Button;
    public Button level4Button;
    public Button level5Button;
    public Button level6Button;
    void Update()
    {
        if (LevelCompletionManager.instance.levelCompletionStatus[0])
        {
            level2Button.interactable = true;
        }
        else
        {
            level2Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[1])
        {
            
            level3Button.interactable = true;
        }
        else
        {
            
            level3Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[2])
        {
            level4Button.interactable = true;
        }
        else
        {
            level4Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[3])
        {
            
            level5Button.interactable = true;
        }
        else
        {
            level5Button.interactable = false;
        }

        if (LevelCompletionManager.instance.levelCompletionStatus[4])
        {
            level6Button.interactable = true;
        }
        else
        {
            level2Button.interactable = false;
        }
        
        
    }
}
