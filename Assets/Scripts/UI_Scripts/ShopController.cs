using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShopController : MonoBehaviour
{
    private GameObject selectedBlaster;
    public void selectBlaster()
    {
        GameManager.instance.setBlasterType(GameManager.instance._classicalBlaster);
    }

    public void upgradeBlaster()
    {
        if (GameManager.instance.getCoins() >= GameManager.instance.classicalBlasterCost)
        {
            GameManager.instance.getCoins() -= GameManager.instance.classicalBlasterCost;
            GameManager.instance.classicalBlasterCost *= 2;
            GameManager.instance.classicalBlasterTimesUp++;
            GameManager.instance._classicalBlaster.GetComponent<Projectile1>().bulletDamage += 20;
        }
    }
    //TODO upgrade logic and balancing

    public void backToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void selectFireBlaster()
    {
        if (GameManager.instance._plasmaBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[1]);
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.plasmaBlasterCost)
        {
            
            GameManager.instance.getCoins() -= GameManager.instance.plasmaBlasterCost;
            GameManager.instance._plasmaBlaster = GameManager.instance.blasterList[1];
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[1]);
        }
    }
    

    public void upgradeFireBlaster()
    {
        if (GameManager.instance.getCoins() >= GameManager.instance.plasmaBlasterCost)
        {
            GameManager.instance._plasmaBlaster = GameManager.instance.blasterList[1];
            
            GameManager.instance.getCoins() -= GameManager.instance.plasmaBlasterCost;
            GameManager.instance.plasmaBlasterCost *= 2;
            GameManager.instance.plasmaBlasterTimesUp++;
        }
    }
    
    public void selectIceBlaster()
    {
        if (GameManager.instance._plasmaBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[2]);
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.iceBlasterCost)
        {
            GameManager.instance.getCoins() -= GameManager.instance.iceBlasterCost;
            GameManager.instance._iceBlaster = GameManager.instance.blasterList[2];
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[2]);
        }
    }
    
    public void upgradeIceBlaster()
    {
        
        //TODO separate the logic of unlocking and upgrading basing on it if the blaster is already unlocked
        
        if (GameManager.instance.getCoins() >= GameManager.instance.iceBlasterCost)
        {
            
            GameManager.instance._iceBlaster = GameManager.instance.blasterList[2];
            GameManager.instance._iceBlaster.GetComponent<Projectile3>().freezeDuration += 0.5f;
            GameManager.instance.getCoins() -= GameManager.instance.iceBlasterCost;
            GameManager.instance.iceBlasterTimesUp++;
            GameManager.instance.iceBlasterCost *= 2;

        }
    }
    
    public void selectTransformationBlaster()
    {
        if (GameManager.instance._transformationBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[3]);
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.transformationBlasterCost)
        {
            GameManager.instance.getCoins() -= GameManager.instance.transformationBlasterCost;
            GameManager.instance._transformationBlaster = GameManager.instance.blasterList[3];
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[3]);
        }
    }

    public void upgradeTransformationBlaster()
    {
        if (GameManager.instance.getCoins() >= GameManager.instance.transformationBlasterCost && GameManager.instance._transformationBlaster)
        {
            GameManager.instance._transformationBlaster = GameManager.instance.blasterList[3];
            
            GameManager.instance.getCoins() -= GameManager.instance.transformationBlasterCost;
            GameManager.instance.transformationBlasterCost *= 2;
            GameManager.instance.transformationBlasterTimesUp++;
        }
    }
    
    public void selectLightBlaster()
    {
        if (GameManager.instance._lightBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[4]);
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.lightBlasterCost)
        {
            GameManager.instance.getCoins() -= GameManager.instance.lightBlasterCost;

            GameManager.instance._lightBlaster = GameManager.instance.blasterList[4];
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[4]);
        }
    }

    public void upgradeLightBlaster()
    {
      
        if (GameManager.instance.getCoins() >= GameManager.instance.lightBlasterCost)
        {
            GameManager.instance._lightBlaster = GameManager.instance.blasterList[4];
            
            GameManager.instance.getCoins() -= GameManager.instance.lightBlasterCost;
            GameManager.instance.lightBlasterCost *= 2;
            GameManager.instance.lightBlasterTimesUp++;
        }
    }
    
    public void selectForceBlaster()
    {
        if (GameManager.instance._forceBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[5]);
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.forceBlasterCost)
        {
            GameManager.instance._forceBlaster = GameManager.instance.blasterList[5];
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[5]);
            
            GameManager.instance.getCoins() -= GameManager.instance.forceBlasterCost;
        }
    }

    public void upgradeForceBlaster()
    {
        if (GameManager.instance.getCoins() >= GameManager.instance.forceBlasterCost)
        {
            GameManager.instance._forceBlaster = GameManager.instance.blasterList[5];
            GameManager.instance.getCoins() -= GameManager.instance.forceBlasterCost;
            GameManager.instance.forceBlasterTimesUp++;
            GameManager.instance.forceBlasterCost *= 2;
        }
    }
    
    public void selectVoidBlaster()
    {
        if (GameManager.instance._voidBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[6]);
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.voidBlasterCost)
        {
            GameManager.instance.getCoins() -= GameManager.instance.voidBlasterCost;

            GameManager.instance._voidBlaster = GameManager.instance.blasterList[6];
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[6]);
        }
    }

    public void upgradeVoidBlaster()
    {
        if (GameManager.instance.getCoins() >= GameManager.instance.voidBlasterCost)
        {
            
            GameManager.instance._voidBlaster = GameManager.instance.blasterList[6];
            GameManager.instance.getCoins() -= GameManager.instance.voidBlasterCost;
            GameManager.instance.voidBlasterTimesUp++;
            GameManager.instance.voidBlasterCost *= 2;
        }
    }
    
    
    
}
