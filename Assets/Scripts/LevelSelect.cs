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
        GameManager.instance.gameSpeed = 4f;
    }
    public void Level2()
    {
        SceneManager.LoadScene("LEVEL2");
    }

    public void SetLevel2Speed()
    {
        GameManager.instance.gameSpeed = 8f;
    }

    public void Level3()
    {
        SceneManager.LoadScene("LEVEL1");
    }
    public void SetLevel3Speed()
    {
        GameManager.instance.gameSpeed = 12f;
    }
    public void Level4()
    {
        SceneManager.LoadScene("LEVEL2");
    }

    public void SetLevel4Speed()
    {
        GameManager.instance.gameSpeed = 16f;
    }



}
