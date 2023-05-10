using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelect : MonoBehaviour
{
    
    public void Level1()
    {   
        SceneManager.LoadScene("LEVEL1");
    }
    public void SetLevel1Speed()
    {
        GameManager.instance.setEnemyHealth(10);
        GameManager.instance.gameSpeed = 4f;
    }
    public void Level2()
    {
        SceneManager.LoadScene("LEVEL1");
    }

    public void SetLevel2Speed()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 5f;
    }

    public void Level3()
    {
        SceneManager.LoadScene("LEVEL1");
    }
    public void SetLevel3Speed()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 6f;
    }
    public void Level4()
    {
        SceneManager.LoadScene("LEVEL1");
    }

    public void SetLevel4Speed()
    {
        GameManager.instance.setEnemyHealth(30);
        GameManager.instance.gameSpeed = 8f;
    }

    public void Level5()
    {
        SceneManager.LoadScene("LEVEL1");
    }

    public void SetLevel5Speed()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;

    }

    public void Level6()
    {
        SceneManager.LoadScene("LEVEL1");
    }

    public void SetLevel6Speed()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;

    }

    public void Boss1Level()
    {
        SceneManager.LoadScene("TYPE1BOSS");
    }

    public void setBoss1Level()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
    }
    
    public void Level2_1()
    {   
        SceneManager.LoadScene("LEVEL2.1");
    }
    public void SetLevel2_1Speed()
    {
        GameManager.instance.setEnemyHealth(10);
        GameManager.instance.gameSpeed = 4f;
    }
    public void Level2_2()
    {
        SceneManager.LoadScene("LEVEL2.1");
    }

    public void SetLevel2_2Speed()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 5f;
    }

    public void Level2_3()
    {
        SceneManager.LoadScene("LEVEL2.1");
    }
    public void SetLevel2_3Speed()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 6f;
    }
    public void Level2_4()
    {
        SceneManager.LoadScene("LEVEL2.1");
    }

    public void SetLevel2_4Speed()
    {
        GameManager.instance.setEnemyHealth(30);
        GameManager.instance.gameSpeed = 8f;
    }

    public void Level2_5()
    {
        SceneManager.LoadScene("LEVEL2.1");
    }

    public void SetLevel2_5Speed()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;

    }

    public void Level2_6()
    {
        SceneManager.LoadScene("LEVEL2.1");
    }

    public void SetLevel2_6Speed()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;

    }

    public void Boss2Level()
    {
        SceneManager.LoadScene("TYPE2BOSS");
    }

    public void setBoss2Level()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;
    }
      
    public void Level3_1()
    {   
        SceneManager.LoadScene("LEVEL1.3");
    }
    public void SetLevel3_1Speed()
    {
        GameManager.instance.setEnemyHealth(10);
        GameManager.instance.gameSpeed = 4f;
    }
    public void Level3_2()
    {
        SceneManager.LoadScene("LEVEL1.3");
    }

    public void SetLevel3_2Speed()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 5f;
    }

    public void Level3_3()
    {
        SceneManager.LoadScene("LEVEL1.3");
    }
    public void SetLevel3_3Speed()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 6f;
    }
    public void Level3_4()
    {
        SceneManager.LoadScene("LEVEL1.3");
    }

    public void SetLevel3_4Speed()
    {
        GameManager.instance.setEnemyHealth(30);
        GameManager.instance.gameSpeed = 8f;
    }

    public void Level3_5()
    {
        SceneManager.LoadScene("LEVEL1.3");
    }

    public void SetLevel3_5Speed()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;

    }

    public void Level3_6()
    {
        SceneManager.LoadScene("LEVEL1.3");
    }

    public void SetLevel3_6Speed()
    {
        GameManager.instance.setEnemyHealth(50);
        GameManager.instance.gameSpeed = 9f;

    }


}
