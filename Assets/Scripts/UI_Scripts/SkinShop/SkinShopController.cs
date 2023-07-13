using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkinShopController : MonoBehaviour
{

    private int skin1Cost = 10;
    private int skin2Cost = 100;
    private int skin3Cost = 150;
    private int skin4Cost = 200;
    private int skin5Cost = 250;
    private int skin6Cost = 300;
    private int unlocked_skins;
    private void Start()
    { 
        unlocked_skins = PlayerPrefs.GetInt("numberOfUnlockedSkins", 1);
        for (int i = 0; i <= unlocked_skins ; i++)
        {
            GameManager.instance.unlockedSkins[i] = GameManager.instance.skins[i];
        }
    }

    public void selectSkin0()
    {
        GameManager.instance.playerSkin = GameManager.instance.unlockedSkins[0];
    }
    public void selectSkin1()
    {
        if (GameManager.instance.unlockedSkins[1] != null)
        {
            GameManager.instance.playerSkin = GameManager.instance.unlockedSkins[1];
        }
        else if (GameManager.instance.getCoins() >= skin1Cost)
        {
            GameManager.instance.unlockedSkins[1] = GameManager.instance.skins[1];
            PlayerPrefs.SetInt("numberOfUnlockedSkins", 1);
        }
    }
    public void selectSkin2()
    {
        if (GameManager.instance.unlockedSkins[2] != null)
        {
            GameManager.instance.playerSkin = GameManager.instance.unlockedSkins[2];
        }
        else if (GameManager.instance.getCoins() >= skin2Cost)
        {
            GameManager.instance.unlockedSkins[2] = GameManager.instance.skins[2];
            PlayerPrefs.SetInt("numberOfUnlockedSkins", 2);
        }    
    }
    public void selectSkin3()
    {
        if (GameManager.instance.unlockedSkins[3] != null)
        {
            GameManager.instance.playerSkin = GameManager.instance.unlockedSkins[3];
        }
        else if (GameManager.instance.getCoins() >= skin3Cost)
        {
            GameManager.instance.unlockedSkins[3] = GameManager.instance.skins[3];
            PlayerPrefs.SetInt("numberOfUnlockedSkins", 3);
        }
        
    }
    public void selectSkin4()
    {
        if (GameManager.instance.unlockedSkins[4] != null)
        {
            GameManager.instance.playerSkin = GameManager.instance.unlockedSkins[4];
        }
        else if (GameManager.instance.getCoins() >= skin4Cost)
        {
            GameManager.instance.unlockedSkins[4] = GameManager.instance.skins[4];
            PlayerPrefs.SetInt("numberOfUnlockedSkins", 4);
        }    
    }
    public void selectSkin5()
    {
        if (GameManager.instance.unlockedSkins[5] != null)
        {
            GameManager.instance.playerSkin = GameManager.instance.unlockedSkins[5];
        }
        else if (GameManager.instance.getCoins() >= skin5Cost)
        {
            GameManager.instance.unlockedSkins[5] = GameManager.instance.skins[5];
            PlayerPrefs.SetInt("numberOfUnlockedSkins", 5);
        }
        
    }
    public void selectSkin6()
    {
        if (GameManager.instance.unlockedSkins[6] != null)
        {
            GameManager.instance.playerSkin = GameManager.instance.unlockedSkins[6];
        }
        else if (GameManager.instance.getCoins() >= skin6Cost)
        {
            GameManager.instance.unlockedSkins[6] = GameManager.instance.skins[6];
            PlayerPrefs.SetInt("numberOfUnlockedSkins", 6);
        }
        
    }
    
    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
