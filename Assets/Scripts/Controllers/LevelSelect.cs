using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelect : MonoBehaviour
{
    
    public void Level1_1()
    {
        GameManager.instance.setCurrentLevel(0);
        Debug.Log("clicked");
        GameManager.instance.setEnemyHealth(10);
        GameManager.instance.gameSpeed = 2f;
        SceneManager.LoadScene("LEVEL1.1");
    }
    public void Level1_2()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[0])
        {
            GameManager.instance.setCurrentLevel(1);
            GameManager.instance.setEnemyHealth(20);
            GameManager.instance.gameSpeed = 3f;
            SceneManager.LoadScene("LEVEL1.1");
        }
    }

    public void Level1_3()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[1])
        {
            GameManager.instance.setCurrentLevel(2);
            GameManager.instance.setEnemyHealth(20);
            GameManager.instance.gameSpeed = 4f;
            SceneManager.LoadScene("LEVEL1.1");
        }
    }
   
    public void Level1_4()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[2])
        {
            GameManager.instance.setCurrentLevel(3);
            GameManager.instance.setEnemyHealth(30);
            GameManager.instance.gameSpeed = 5f;
            SceneManager.LoadScene("LEVEL1.1");
        }
    }
    
    public void Level1_5()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[3])
        {
            GameManager.instance.setCurrentLevel(4);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 6f;
            SceneManager.LoadScene("LEVEL1.1");
        }
    }
    

    public void Level1_6()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[4])
        {
            GameManager.instance.setCurrentLevel(5);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 7f;
            SceneManager.LoadScene("LEVEL1.1");
        }
    }

    public void Boss1Level()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[5])
        {
            GameManager.instance.setCurrentLevel(6);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 8f;
            SceneManager.LoadScene("TYPE1BOSS");
        }
    }
    
    public void Level2_1()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[6])
        {
            GameManager.instance.setCurrentLevel(7);
            GameManager.instance.setEnemyHealth(10);
            GameManager.instance.gameSpeed = 2f;
            SceneManager.LoadScene("LEVEL2.1");
        }
    }
  
    public void Level2_2()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[7])
        {
            GameManager.instance.setCurrentLevel(8);
            GameManager.instance.setEnemyHealth(20);
            GameManager.instance.gameSpeed = 3f;
            SceneManager.LoadScene("LEVEL2.1");
        }
    }
    

    public void Level2_3()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[8])
        {
            GameManager.instance.setCurrentLevel(9);
            GameManager.instance.setEnemyHealth(20);
            GameManager.instance.gameSpeed = 4f;
            SceneManager.LoadScene("LEVEL2.1");
        }
    }
    public void Level2_4()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[9])
        {
            GameManager.instance.setCurrentLevel(10);
            GameManager.instance.setEnemyHealth(30);
            GameManager.instance.gameSpeed = 5f;
            SceneManager.LoadScene("LEVEL2.1");
        }
    }

  

    public void Level2_5()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[10])
        {
            GameManager.instance.setCurrentLevel(11);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 6f;
            SceneManager.LoadScene("LEVEL2.1");
        }
    }
    

    public void Level2_6()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[11])
        {
            GameManager.instance.setCurrentLevel(12);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 7f;
            SceneManager.LoadScene("LEVEL2.1");
        }
    }

    public void Boss2Level()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[12])
        {
            GameManager.instance.setCurrentLevel(13);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 8f;
            SceneManager.LoadScene("TYPE2BOSS");
        }
    }

    public void Level3_1()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[13])
        {
            GameManager.instance.setCurrentLevel(14);
            GameManager.instance.setEnemyHealth(10);
            GameManager.instance.gameSpeed = 2f;
            SceneManager.LoadScene("LEVEL3.1");
        }
    }
    public void Level3_2()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[14])
        {
            GameManager.instance.setCurrentLevel(15);
            GameManager.instance.setEnemyHealth(20);
            GameManager.instance.gameSpeed = 3f;
            SceneManager.LoadScene("LEVEL3.1");
        }
    }

    public void Level3_3()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[15])
        {
            GameManager.instance.setCurrentLevel(16);
            GameManager.instance.setEnemyHealth(20);
            GameManager.instance.gameSpeed = 4f;
            SceneManager.LoadScene("LEVEL3.1");
        }
    }
    public void Level3_4()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[16])
        {
            GameManager.instance.setCurrentLevel(17);
            GameManager.instance.setEnemyHealth(30);
            GameManager.instance.gameSpeed = 5f;
            SceneManager.LoadScene("LEVEL3.1");
        }
    }
    

    public void Level3_5()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[17])
        {
            GameManager.instance.setCurrentLevel(18);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 6f;
            SceneManager.LoadScene("LEVEL3.1");
        }
    }

    public void Level3_6()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[18])
        {
            GameManager.instance.setCurrentLevel(19);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 7f;
            SceneManager.LoadScene("LEVEL3.1");
        }
    }
    public void Boss3Level()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[19])
        {
            GameManager.instance.setCurrentLevel(20);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 8f;
            SceneManager.LoadScene("TYPE3BOSS");
        }
    }
    public void Level4_1()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[20])
        {
            GameManager.instance.setCurrentLevel(21);
            GameManager.instance.setEnemyHealth(10);
            GameManager.instance.gameSpeed = 2f;
            SceneManager.LoadScene("LEVEL4.1");
        }
    }

    public void Level4_2()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[21])
        {
            GameManager.instance.setCurrentLevel(22);
            GameManager.instance.setEnemyHealth(20);
            GameManager.instance.gameSpeed = 3f;
            SceneManager.LoadScene("LEVEL4.1");
        }
    }

    public void Level4_3()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[22])
        {
            GameManager.instance.setCurrentLevel(23);
            GameManager.instance.setEnemyHealth(20);
            GameManager.instance.gameSpeed = 4f;
            SceneManager.LoadScene("LEVEL4.1");
        }
    }

    public void Level4_4()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[23])
        {
            GameManager.instance.setCurrentLevel(24);
            GameManager.instance.setEnemyHealth(30);
            GameManager.instance.gameSpeed = 5f;
            SceneManager.LoadScene("LEVEL4.1");
        }
    }


    public void Level4_5()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[24])
        {
            GameManager.instance.setCurrentLevel(25);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 6f;
            SceneManager.LoadScene("LEVEL4.1");
        }
    }

    public void Level4_6()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[25])
        {
            GameManager.instance.setCurrentLevel(26);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 7f;
            SceneManager.LoadScene("LEVEL4.1");
        }
    }

    public void Boss4Level()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[26])
        {
            GameManager.instance.setCurrentLevel(27);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 8f;
            SceneManager.LoadScene("TYPE4BOSS");
        }
    }

    public void Level5_1()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[27])
        {
            GameManager.instance.setCurrentLevel(28);
            GameManager.instance.setEnemyHealth(10);
            GameManager.instance.gameSpeed = 2f;
            SceneManager.LoadScene("LEVEL5.1");
        }
    }

    public void Level5_2()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[28])
        {
            GameManager.instance.setCurrentLevel(29);
            GameManager.instance.setEnemyHealth(20);
            GameManager.instance.gameSpeed = 3f;
            SceneManager.LoadScene("LEVEL5.1");
        }
    }

    public void Level5_3()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[29])
        {
            GameManager.instance.setCurrentLevel(30);
            GameManager.instance.setEnemyHealth(20);
            GameManager.instance.gameSpeed = 4f;
            SceneManager.LoadScene("LEVEL5.1");
        }
    }

    public void Level5_4()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[30])
        {
            GameManager.instance.setCurrentLevel(31);
            GameManager.instance.setEnemyHealth(30);
            GameManager.instance.gameSpeed = 5f;
            SceneManager.LoadScene("LEVEL5.1");
        }
    }


    public void Level5_5()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[31])
        {
            GameManager.instance.setCurrentLevel(32);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 6f;
            SceneManager.LoadScene("LEVEL5.1");
        }
    }

    public void Level5_6()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[32])
        {
            GameManager.instance.setCurrentLevel(33);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 7f;
            SceneManager.LoadScene("LEVEL5.1");
        }
    }

    public void Boss5Level()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[33])
        {
            GameManager.instance.setCurrentLevel(34);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 8f;
            SceneManager.LoadScene("TYPE5BOSS");
        }
    }

    public void Level6_1()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[34])
        {
            GameManager.instance.setCurrentLevel(35);
            GameManager.instance.setEnemyHealth(10);
            GameManager.instance.gameSpeed = 2f;
            SceneManager.LoadScene("LEVEL6.1");
        }
    }

    public void Level6_2()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[35])
        {
            GameManager.instance.setCurrentLevel(36);
            GameManager.instance.setEnemyHealth(20);
            GameManager.instance.gameSpeed = 3f;
            SceneManager.LoadScene("LEVEL6.1");
        }
    }

    public void Level6_3()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[36])
        {
            GameManager.instance.setCurrentLevel(37);
            GameManager.instance.setEnemyHealth(20);
            GameManager.instance.gameSpeed = 4f;
            SceneManager.LoadScene("LEVEL6.1");
        }
    }

    public void Level6_4()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[37])
        {
            GameManager.instance.setCurrentLevel(38);
            GameManager.instance.setEnemyHealth(30);
            GameManager.instance.gameSpeed = 5f;
            SceneManager.LoadScene("LEVEL6.1");
        }
    }


    public void Level6_5()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[38])
        {
            GameManager.instance.setCurrentLevel(39);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 6f;
            SceneManager.LoadScene("LEVEL6.1");
        }
    }

    public void Level6_6()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[39])
        {
            GameManager.instance.setCurrentLevel(40);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 7f;
            SceneManager.LoadScene("LEVEL6.1");
        }
    }

    public void Boss6Level()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[40])
        {
            GameManager.instance.setCurrentLevel(41);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 8f;
            SceneManager.LoadScene("TYPE6BOSS");
        }
    }

    public void Level7_1()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[41])
        {
            GameManager.instance.setCurrentLevel(42);
            GameManager.instance.setEnemyHealth(10);
            GameManager.instance.gameSpeed = 2f;
            SceneManager.LoadScene("LEVEL7.1");
        }
    }

    public void Level7_2()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[42])
        {
            GameManager.instance.setCurrentLevel(43);
            GameManager.instance.setEnemyHealth(20);
            GameManager.instance.gameSpeed = 3f;
            SceneManager.LoadScene("LEVEL7.1");
        }
    }

    public void Level7_3()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[43])
        {
            GameManager.instance.setCurrentLevel(44);
            GameManager.instance.setEnemyHealth(20);
            GameManager.instance.gameSpeed = 4f;
            SceneManager.LoadScene("LEVEL7.1");
        }
    }

    public void Level7_4()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[44])
        {
            GameManager.instance.setCurrentLevel(45);
            GameManager.instance.setEnemyHealth(30);
            GameManager.instance.gameSpeed = 5f;
            SceneManager.LoadScene("LEVEL7.1");
        }
    }


    public void Level7_5()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[45])
        {
            GameManager.instance.setCurrentLevel(46);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 6f;
            SceneManager.LoadScene("LEVEL7.1");
        }
    }

    public void Level7_6()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[46])
        {
            GameManager.instance.setCurrentLevel(47);
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 7f;
            SceneManager.LoadScene("LEVEL7.1");
        }
    }

    public void Boss7Level()
    {
        if (LevelCompletionManager.instance.getLevelCompletionStatus()[47])
        {
            GameManager.instance.setEnemyHealth(50);
            GameManager.instance.gameSpeed = 8f;
            SceneManager.LoadScene("TYPE7BOSS");
        }
    }

    public void exitToMM()
    {
        
        SceneManager.LoadScene("MainMenu");
        
    }

}
