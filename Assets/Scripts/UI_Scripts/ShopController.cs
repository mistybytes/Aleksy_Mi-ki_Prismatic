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
        GameManager.instance.setBlasterType(GameManager.instance.classicalBlaster);
        GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().setVariables();
    }

    public void upgradeBlaster()
    {
        if (GameManager.instance.getCoins() >= GameManager.instance.classicalBlasterCost)
        {
            GameManager.instance.getCoins() -= GameManager.instance.classicalBlasterCost;
            GameManager.instance.classicalBlasterCost *= 2;
            GameManager.instance.classicalBlasterTimesUp++;
            GameManager.instance.classicalBlaster.GetComponent<Projectile1>().upgradeBlaster1();
            
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.2f,0,1);

        }
    }
    //TODO upgrade logic and balancing

    public void backToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void selectFireBlaster()
    {
        if (GameManager.instance.plasmaBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[1]);
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().setVariables();

        }
    }
    

    public void upgradeFireBlaster()
    {
        if (GameManager.instance.plasmaBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.plasmaBlasterCost)
        {
            GameManager.instance.plasmaBlaster = GameManager.instance.blasterList[1];
            GameManager.instance.getCoins() -= GameManager.instance.plasmaBlasterCost;
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.plasmaBlasterCost)
        {
            GameManager.instance.plasmaBlaster = GameManager.instance.blasterList[1];
            GameManager.instance.getCoins() -= GameManager.instance.plasmaBlasterCost;
            GameManager.instance.plasmaBlasterCost *= 2;
            GameManager.instance.plasmaBlasterTimesUp++;
            
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.2f,0,1);

        }
    }
    
    public void selectIceBlaster()
    {
        if (GameManager.instance.iceBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[2]);
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().setVariables();
        }
    }
    
    public void upgradeIceBlaster()
    {
        if (GameManager.instance.iceBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.iceBlasterCost)
        {
            GameManager.instance.iceBlaster = GameManager.instance.blasterList[2];
            GameManager.instance.getCoins() -= GameManager.instance.iceBlasterCost;
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.iceBlasterCost)
        {
            GameManager.instance.iceBlaster = GameManager.instance.blasterList[2];
            GameManager.instance.getCoins() -= GameManager.instance.iceBlasterCost;
            GameManager.instance.iceBlasterTimesUp++;
            GameManager.instance.iceBlasterCost *= 2;
            
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.2f,0,1);
        }
    }
    
    public void selectTransformationBlaster()
    {
        if (GameManager.instance.transformationBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[3]);
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().setVariables();

        }
    }

    public void upgradeTransformationBlaster()
    {
        if (GameManager.instance.transformationBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.transformationBlasterCost)
        {
            GameManager.instance.transformationBlaster = GameManager.instance.blasterList[3];
            GameManager.instance.getCoins() -= GameManager.instance.plasmaBlasterCost;
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.transformationBlasterCost && GameManager.instance.transformationBlaster)
        {
            GameManager.instance.transformationBlaster = GameManager.instance.blasterList[3];
            GameManager.instance.getCoins() -= GameManager.instance.transformationBlasterCost;
            GameManager.instance.transformationBlasterCost *= 2;
            GameManager.instance.transformationBlasterTimesUp++;
            
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.2f,0,1);

        }
    }
    
    public void selectLightBlaster()
    {
        if (GameManager.instance.lightBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[4]);
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().setVariables();

        }
    }

    public void upgradeLightBlaster()
    {
      
        if (GameManager.instance.lightBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.lightBlasterCost)
        {
            GameManager.instance.lightBlaster = GameManager.instance.blasterList[4];
            GameManager.instance.getCoins() -= GameManager.instance.lightBlasterCost;
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.lightBlasterCost)
        {
            GameManager.instance.lightBlaster = GameManager.instance.blasterList[4];
            
            GameManager.instance.getCoins() -= GameManager.instance.lightBlasterCost;
            GameManager.instance.lightBlasterCost *= 2;
            GameManager.instance.lightBlasterTimesUp++;
            
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.2f,0,1);

        }
    }
    
    public void selectForceBlaster()
    {
        if (GameManager.instance.forceBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[5]);
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().setVariables();

        }
    }

    public void upgradeForceBlaster()
    {
        if (GameManager.instance.forceBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.forceBlasterCost)
        {
            GameManager.instance.forceBlaster = GameManager.instance.blasterList[5];
            GameManager.instance.getCoins() -= GameManager.instance.forceBlasterCost;
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.forceBlasterCost)
        {
            GameManager.instance.forceBlaster = GameManager.instance.blasterList[5];
            GameManager.instance.getCoins() -= GameManager.instance.forceBlasterCost;
            GameManager.instance.forceBlasterTimesUp++;
            GameManager.instance.forceBlasterCost *= 2;
            
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.2f,0,1);

        }
    }
    
    public void selectVoidBlaster()
    {
        if (GameManager.instance.voidBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[6]);
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().setVariables();
        }
    }

    public void upgradeVoidBlaster()
    {
        if (GameManager.instance.voidBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.voidBlasterCost)
        {
            GameManager.instance.voidBlaster = GameManager.instance.blasterList[6];
            GameManager.instance.getCoins() -= GameManager.instance.voidBlasterCost;
        }
        if (GameManager.instance.getCoins() >= GameManager.instance.voidBlasterCost)
        {
            GameManager.instance.voidBlaster = GameManager.instance.blasterList[6];
            GameManager.instance.getCoins() -= GameManager.instance.voidBlasterCost;
            GameManager.instance.voidBlasterCost *= 2;
            
            GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.2f,0,1);

        }
    }
    
    
    
}
