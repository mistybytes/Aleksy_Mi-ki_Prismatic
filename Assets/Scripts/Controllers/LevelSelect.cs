using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelect : MonoBehaviour
{
    
    public void Level1_1()
    {
        GameManager.instance.setEnemyHealth(10);
        GameManager.instance.gameSpeed = 4f;
        Debug.Log("clicked lvl 1");
        SceneManager.LoadScene("LEVEL1.1");
    }
    public void Level1_2()
    {
        
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 5f;
        SceneManager.LoadScene("LEVEL1.1");
        
    }

    public void Level1_3()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 6f;
        SceneManager.LoadScene("LEVEL1.1");
    }
   
    public void Level1_4()
    {
        GameManager.instance.setEnemyHealth(30);
        GameManager.instance.gameSpeed = 8f;
        SceneManager.LoadScene("LEVEL1.1");
    }
    
    public void Level1_5()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL1.1");
    }
    

    public void Level1_6()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL1.1");
    }

    public void Boss1Level()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("TYPE1BOSS");
    }
    
    public void Level2_1()
    {   
        
        GameManager.instance.setEnemyHealth(10);
        GameManager.instance.gameSpeed = 4f;
        SceneManager.LoadScene("LEVEL2.1");
    }
  
    public void Level2_2()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 5f;
        SceneManager.LoadScene("LEVEL2.1");
    }
    

    public void Level2_3()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 6f;
        SceneManager.LoadScene("LEVEL2.1");
    }
    public void Level2_4()
    {
        GameManager.instance.setEnemyHealth(30);
        GameManager.instance.gameSpeed = 8f;
        SceneManager.LoadScene("LEVEL2.1");
    }

  

    public void Level2_5()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL2.1");
    }
    

    public void Level2_6()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL2.1");
    }

    public void Boss2Level()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("TYPE2BOSS");
    }

    public void Level3_1()
    {   
        GameManager.instance.setEnemyHealth(10);
        GameManager.instance.gameSpeed = 4f;
        SceneManager.LoadScene("LEVEL3.1");
    }
    public void Level3_2()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 5f;
        SceneManager.LoadScene("LEVEL3.1");
    }

    public void Level3_3()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 6f;
        SceneManager.LoadScene("LEVEL3.1");
    }
    public void Level3_4()
    {
        GameManager.instance.setEnemyHealth(30);
        GameManager.instance.gameSpeed = 8f;
        SceneManager.LoadScene("LEVEL3.1");
    }
    

    public void Level3_5()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL3.1");
    }

    public void Level3_6()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL3.1");
    }
    public void Boss3Level()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("TYPE3BOSS");
    }
    public void Level4_1()
    {   
        GameManager.instance.setEnemyHealth(10);
        GameManager.instance.gameSpeed = 4f;
        SceneManager.LoadScene("LEVEL4.1");
    }
    public void Level4_2()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 5f;
        SceneManager.LoadScene("LEVEL4.1");
    }

    public void Level4_3()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 6f;
        SceneManager.LoadScene("LEVEL4.1");
    }
    public void Level4_4()
    {
        GameManager.instance.setEnemyHealth(30);
        GameManager.instance.gameSpeed = 8f;
        SceneManager.LoadScene("LEVEL4.1");
    }
    

    public void Level4_5()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL4.1");
    }

    public void Level4_6()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL4.1");
    }
    public void Boss4Level()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("TYPE4BOSS");
    }
    public void Level5_1()
    {   
        GameManager.instance.setEnemyHealth(10);
        GameManager.instance.gameSpeed = 4f;
        SceneManager.LoadScene("LEVEL5.1");
    }
    public void Level5_2()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 5f;
        SceneManager.LoadScene("LEVEL5.1");
    }

    public void Level5_3()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 6f;
        SceneManager.LoadScene("LEVEL5.1");
    }
    public void Level5_4()
    {
        GameManager.instance.setEnemyHealth(30);
        GameManager.instance.gameSpeed = 8f;
        SceneManager.LoadScene("LEVEL5.1");
    }
    

    public void Level5_5()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL5.1");
    }

    public void Level5_6()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL5.1");
    }
    public void Boss5Level()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("TYPE5BOSS");
    }
    public void Level6_1()
    {   
        GameManager.instance.setEnemyHealth(10);
        GameManager.instance.gameSpeed = 4f;
        SceneManager.LoadScene("LEVEL6.1");
    }
    public void Level6_2()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 5f;
        SceneManager.LoadScene("LEVEL6.1");
    }

    public void Level6_3()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 6f;
        SceneManager.LoadScene("LEVEL6.1");
    }
    public void Level6_4()
    {
        GameManager.instance.setEnemyHealth(30);
        GameManager.instance.gameSpeed = 8f;
        SceneManager.LoadScene("LEVEL6.1");
    }
    

    public void Level6_5()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL6.1");
    }

    public void Level6_6()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL6.1");
    }
    public void Boss6Level()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("TYPE6BOSS");
    }
    
    public void Level7_1()
    {   
        GameManager.instance.setEnemyHealth(10);
        GameManager.instance.gameSpeed = 4f;
        SceneManager.LoadScene("LEVEL7.1");
    }
    public void Level7_2()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 5f;
        SceneManager.LoadScene("LEVEL7.1");
    }

    public void Level7_3()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 6f;
        SceneManager.LoadScene("LEVEL7.1");
    }
    public void Level7_4()
    {
        GameManager.instance.setEnemyHealth(30);
        GameManager.instance.gameSpeed = 8f;
        SceneManager.LoadScene("LEVEL7.1");
    }
    

    public void Level7_5()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL7.1");
    }

    public void Level7_6()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL7.1");
    }
    public void Boss7Level()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("TYPE7BOSS");
    }
    public void exitToMM()
    {
        
        SceneManager.LoadScene("MainMenu");
        
    }

}
