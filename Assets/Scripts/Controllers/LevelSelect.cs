using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelect : MonoBehaviour
{
    
    public void Level1()
    {   
        GameManager.instance.setEnemyHealth(10);
        GameManager.instance.gameSpeed = 4f;
        SceneManager.LoadScene("LEVEL1");
    }
    public void Level2()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 5f;
        SceneManager.LoadScene("LEVEL1");
    }

    public void Level3()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 6f;
        SceneManager.LoadScene("LEVEL1");
    }
   
    public void Level4()
    {
        GameManager.instance.setEnemyHealth(30);
        GameManager.instance.gameSpeed = 8f;
        SceneManager.LoadScene("LEVEL1");
    }
    
    public void Level5()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL1");
    }
    

    public void Level6()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL1");
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
        SceneManager.LoadScene("LEVEL1.3");
    }
    public void Level3_2()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 5f;
        SceneManager.LoadScene("LEVEL1.3");
    }

    public void Level3_3()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 6f;
        SceneManager.LoadScene("LEVEL1.3");
    }
    public void Level3_4()
    {
        GameManager.instance.setEnemyHealth(30);
        GameManager.instance.gameSpeed = 8f;
        SceneManager.LoadScene("LEVEL1.3");
    }
    

    public void Level3_5()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL1.3");
    }

    public void Level3_6()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
        SceneManager.LoadScene("LEVEL1.3");
    }

    public void exitToMM()
    {
        
        SceneManager.LoadScene("MainMenu");
        
    }

}
