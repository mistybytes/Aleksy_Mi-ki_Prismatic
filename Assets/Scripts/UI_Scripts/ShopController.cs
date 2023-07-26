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
        GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().setVariables();
    }

    public void upgradeBlaster()
    {
        if (GameManager.instance.getCoins() >= GameManager.instance.classicalBlasterCost)
        {
            GameManager.instance.getCoins() -= GameManager.instance.classicalBlasterCost;
            GameManager.instance.classicalBlasterCost *= 2;
            GameManager.instance.classicalBlasterTimesUp++;
            GameManager.instance._classicalBlaster.GetComponent<Projectile1>().upgradeBlaster1();
            
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.2f,0);

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
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().setVariables();

        }
    }
    

    public void upgradeFireBlaster()
    {
        if (GameManager.instance._plasmaBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.plasmaBlasterCost)
        {
            GameManager.instance._plasmaBlaster = GameManager.instance.blasterList[1];
            GameManager.instance.getCoins() -= GameManager.instance.plasmaBlasterCost;
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.plasmaBlasterCost)
        {
            GameManager.instance._plasmaBlaster = GameManager.instance.blasterList[1];
            GameManager.instance.getCoins() -= GameManager.instance.plasmaBlasterCost;
            GameManager.instance.plasmaBlasterCost *= 2;
            GameManager.instance.plasmaBlasterTimesUp++;
            
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.2f,0);

        }
    }
    
    public void selectIceBlaster()
    {
        if (GameManager.instance._plasmaBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[2]);
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().setVariables();

        }
    }
    
    public void upgradeIceBlaster()
    {
        if (GameManager.instance._iceBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.iceBlasterCost)
        {
            GameManager.instance._iceBlaster = GameManager.instance.blasterList[2];
            GameManager.instance.getCoins() -= GameManager.instance.iceBlasterCost;
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.iceBlasterCost)
        {
            
            GameManager.instance._iceBlaster = GameManager.instance.blasterList[2];
            GameManager.instance._iceBlaster.GetComponent<Projectile3>().freezeDuration += 0.5f;
            GameManager.instance.getCoins() -= GameManager.instance.iceBlasterCost;
            GameManager.instance.iceBlasterTimesUp++;
            GameManager.instance.iceBlasterCost *= 2;
            
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.2f,0);

        }
    }
    
    public void selectTransformationBlaster()
    {
        if (GameManager.instance._transformationBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[3]);
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().setVariables();

        }
    }

    public void upgradeTransformationBlaster()
    {
        if (GameManager.instance._transformationBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.transformationBlasterCost)
        {
            GameManager.instance._transformationBlaster = GameManager.instance.blasterList[3];
            GameManager.instance.getCoins() -= GameManager.instance.plasmaBlasterCost;
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.transformationBlasterCost && GameManager.instance._transformationBlaster)
        {
            GameManager.instance._transformationBlaster = GameManager.instance.blasterList[3];
            GameManager.instance.getCoins() -= GameManager.instance.transformationBlasterCost;
            GameManager.instance.transformationBlasterCost *= 2;
            GameManager.instance.transformationBlasterTimesUp++;
            
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.2f,0);

        }
    }
    
    public void selectLightBlaster()
    {
        if (GameManager.instance._lightBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[4]);
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().setVariables();

        }
    }

    public void upgradeLightBlaster()
    {
      
        if (GameManager.instance._lightBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.lightBlasterCost)
        {
            GameManager.instance._lightBlaster = GameManager.instance.blasterList[4];
            GameManager.instance.getCoins() -= GameManager.instance.lightBlasterCost;
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.lightBlasterCost)
        {
            GameManager.instance._lightBlaster = GameManager.instance.blasterList[4];
            
            GameManager.instance.getCoins() -= GameManager.instance.lightBlasterCost;
            GameManager.instance.lightBlasterCost *= 2;
            GameManager.instance.lightBlasterTimesUp++;
            
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.2f,0);

        }
    }
    
    public void selectForceBlaster()
    {
        if (GameManager.instance._forceBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[5]);
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().setVariables();

        }
    }

    public void upgradeForceBlaster()
    {
        if (GameManager.instance._forceBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.forceBlasterCost)
        {
            GameManager.instance._forceBlaster = GameManager.instance.blasterList[5];
            GameManager.instance.getCoins() -= GameManager.instance.forceBlasterCost;
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.forceBlasterCost)
        {
            GameManager.instance._forceBlaster = GameManager.instance.blasterList[5];
            GameManager.instance.getCoins() -= GameManager.instance.forceBlasterCost;
            GameManager.instance.forceBlasterTimesUp++;
            GameManager.instance.forceBlasterCost *= 2;
            
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.2f,0);

        }
    }
    
    public void selectVoidBlaster()
    {
        if (GameManager.instance._voidBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[6]);
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().setVariables();
        }
    }

    public void upgradeVoidBlaster()
    {
        if (GameManager.instance._voidBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.voidBlasterCost)
        {
            GameManager.instance._voidBlaster = GameManager.instance.blasterList[6];
            GameManager.instance.getCoins() -= GameManager.instance.voidBlasterCost;
        }
        if (GameManager.instance.getCoins() >= GameManager.instance.voidBlasterCost)
        {
            GameManager.instance._voidBlaster = GameManager.instance.blasterList[6];
            GameManager.instance.getCoins() -= GameManager.instance.voidBlasterCost;
            GameManager.instance.voidBlasterTimesUp++;
            GameManager.instance.voidBlasterCost *= 2;
            
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.2f,0);

        }
    }
    
    
    
}
