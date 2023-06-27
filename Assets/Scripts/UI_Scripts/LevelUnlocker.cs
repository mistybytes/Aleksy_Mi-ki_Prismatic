using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocker : MonoBehaviour
{
    //location 1 buttons
    public Button level1_2Button;
    public Button level1_3Button;
    public Button level1_4Button;
    public Button level1_5Button;
    public Button level1_6Button;
    public Button level1BossButton;
    //location 2 buttons
    public Button level2_1Button;
    public Button level2_2Button;
    public Button level2_3Button;
    public Button level2_4Button;
    public Button level2_5Button;
    public Button level2_6Button;
    public Button level2BossButton;
    //location 3 buttons
    public Button level3_1Button;
    public Button level3_2Button;
    public Button level3_3Button;
    public Button level3_4Button;
    public Button level3_5Button;
    public Button level3_6Button;
    public Button level3BossButton;
    //location 4 buttons
    public Button level4_1Button;
    public Button level4_2Button;
    public Button level4_3Button;
    public Button level4_4Button;
    public Button level4_5Button;
    public Button level4_6Button;
    public Button level4BossButton;
    //location 5 buttons
    public Button level5_1Button;
    public Button level5_2Button;
    public Button level5_3Button;
    public Button level5_4Button;
    public Button level5_5Button;
    public Button level5_6Button;
    public Button level5BossButton;
    //location 6 buttons
    public Button level6_1Button;
    public Button level6_2Button;
    public Button level6_3Button;
    public Button level6_4Button;
    public Button level6_5Button;
    public Button level6_6Button;
    public Button level6BossButton;
    //location 7 buttons
    public Button level7_1Button;
    public Button level7_2Button;
    public Button level7_3Button;
    public Button level7_4Button;
    public Button level7_5Button;
    public Button level7_6Button;
    public Button level7BossButton;
    
    void Start()
    {
        
        if (LevelCompletionManager.instance.levelCompletionStatus[0])
        {
            level1_2Button.interactable = true;
        }
        else
        {
            level1_2Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[1])
        {
            
            level1_3Button.interactable = true;
        }
        else
        {
            level1_3Button.interactable = false;
        
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[2])
        {
            level1_4Button.interactable = true;
        }
        else
        {
            level1_4Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[3])
        {
            
            level1_5Button.interactable = true;
        }
        else
        {
            level1_5Button.interactable = false;
        }

        if (LevelCompletionManager.instance.levelCompletionStatus[4])
        {
            level1_6Button.interactable = true;
        }
        else
        {
            level1_6Button.interactable = false;
        }
        
        if (LevelCompletionManager.instance.levelCompletionStatus[5])
        {
            level1BossButton.interactable = true;
        }
        else
        {
            level1BossButton.interactable = false;
        }
        //location 2 buttons
        if (LevelCompletionManager.instance.levelCompletionStatus[6])
        {
            level2_1Button.interactable = true;
        }
        else
        {
            level2_1Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[7])
        {
            level2_2Button.interactable = true;
        }
        else
        {
            level2_2Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[8])
        {
            level2_3Button.interactable = true;
        }
        else
        {
            level2_3Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[9])
        {
            level2_4Button.interactable = true;
        }
        else
        {
            level2_4Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[10])
        {
            level2_5Button.interactable = true;
        }
        else
        {
            level2_5Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[11])
        {
            level2_6Button.interactable = true;
        }
        else
        {
            level2_6Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[12])
        {
            level2BossButton.interactable = true;
        }
        else
        {
            level2BossButton.interactable = false;
        }
        //location 3 buttons 
        if (LevelCompletionManager.instance.levelCompletionStatus[13])
        {
            level3_1Button.interactable = true;
        }
        else
        {
            level3_1Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[14])
        {
            level3_2Button.interactable = true;
        }
        else
        {
            level3_2Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[15])
        {
            level3_3Button.interactable = true;
        }
        else
        {
            level3_3Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[16])
        {
            level3_4Button.interactable = true;
        }
        else
        {
            level3_4Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[17])
        {
            level3_5Button.interactable = true;
        }
        else
        {
            level3_5Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[18])
        {
            level3_6Button.interactable = true;
        }
        else
        {
            level3_6Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[19])
        {
            level3BossButton.interactable = true;
        }
        else
        {
            level3BossButton.interactable = false;
        }
        //location 4 buttons
        if (LevelCompletionManager.instance.levelCompletionStatus[20])
        {
            level4_1Button.interactable = true;
        }
        else
        {
            level4_1Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[21])
        {
            level4_2Button.interactable = true;
        }
        else
        {
            level4_2Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[22])
        {
            level4_3Button.interactable = true;
        }
        else
        {
            level4_3Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[23])
        {
            level4_4Button.interactable = true;
        }
        else
        {
            level4_4Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[24])
        {
            level4_5Button.interactable = true;
        }
        else
        {
            level4_5Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[25])
        {
            level4_6Button.interactable = true;
        }
        else
        {
            level4_6Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[26])
        {
            level4BossButton.interactable = true;
        }
        else
        {
            level4BossButton.interactable = false;
        }
        //location 5 buttons
        if (LevelCompletionManager.instance.levelCompletionStatus[27])
        {
            level5_1Button.interactable = true;
        }
        else
        {
            level5_1Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[28])
        {
            level5_2Button.interactable = true;
        }
        else
        {
            level5_2Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[29])
        {
            level5_3Button.interactable = true;
        }
        else
        {
            level5_3Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[30])
        {
            level5_4Button.interactable = true;
        }
        else
        {
            level5_4Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[31])
        {
            level5_5Button.interactable = true;
        }
        else
        {
            level5_5Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[32])
        {
            level5_6Button.interactable = true;
        }
        else
        {
            level5_6Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[33])
        {
            level5BossButton.interactable = true;
        }
        else
        {
            level5BossButton.interactable = false;
        }
        //location 6 buttons
        if (LevelCompletionManager.instance.levelCompletionStatus[34])
        {
            level6_1Button.interactable = true;
        }
        else
        {
            level6_1Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[35])
        {
            level6_2Button.interactable = true;
        }
        else
        {
            level6_2Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[36])
        {
            level6_3Button.interactable = true;
        }
        else
        {
            level6_3Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[37])
        {
            level6_4Button.interactable = true;
        }
        else
        {
            level6_4Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[38])
        {
            level6_5Button.interactable = true;
        }
        else
        {
            level6_5Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[39])
        {
            level6_6Button.interactable = true;
        }
        else
        {
            level6_6Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[40])
        {
            level6BossButton.interactable = true;
        }
        else
        {
            level6BossButton.interactable = false;
        }
        //location 7 buttons
        if (LevelCompletionManager.instance.levelCompletionStatus[41])
        {
            level7_1Button.interactable = true;
        }
        else
        {
            level7_1Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[42])
        {
            level7_2Button.interactable = true;
        }
        else
        {
            level7_2Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[43])
        {
            level7_3Button.interactable = true;
        }
        else
        {
            level7_3Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[44])
        {
            level7_4Button.interactable = true;
        }
        else
        {
            level7_4Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[45])
        {
            level7_5Button.interactable = true;
        }
        else
        {
            level7_5Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[46])
        {
            level7_6Button.interactable = true;
        }
        else
        {
            level7_6Button.interactable = false;
        }
        if (LevelCompletionManager.instance.levelCompletionStatus[47])
        {
            level7BossButton.interactable = true;
        }
        else
        {
            level7BossButton.interactable = false;
        }
        
        
    }
}
