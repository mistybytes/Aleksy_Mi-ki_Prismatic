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
        SceneManager.LoadScene("LEVEL2");
    }

    public void SetLevel2Speed()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 8f;
    }

    public void Level3()
    {
        SceneManager.LoadScene("LEVEL3");
    }
    public void SetLevel3Speed()
    {
        GameManager.instance.setEnemyHealth(20);
        GameManager.instance.gameSpeed = 8f;
    }
    public void Level4()
    {
        SceneManager.LoadScene("LEVEL4");
    }

    public void SetLevel4Speed()
    {
        GameManager.instance.setEnemyHealth(30);
        GameManager.instance.gameSpeed = 12f;
    }

    public void Level5()
    {
        SceneManager.LoadScene("LEVEL5");
    }

    public void SetLevel5Speed()
    {
        GameManager.instance.setEnemyHealth(50);
        
    }



}
