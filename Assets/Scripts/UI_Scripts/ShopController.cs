using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShopController : MonoBehaviour
{
    public void SelectBlaster()
    {
        GameManager.instance.setBlasterType(GameManager.instance.classicalBlaster);
        BlasterVariables.instance.SetBlaster1Variables();
    }
    
    public void UpgradeBlaster()
    {
        if (GameManager.instance.getCoins() >= GameManager.instance.classicalBlasterCost && GameManager.instance.classicalBlasterTimesUp < 7)
        {
            GameManager.instance.getCoins() -= GameManager.instance.classicalBlasterCost;
            GameManager.instance.classicalBlasterCost *= 2;
            GameManager.instance.classicalBlasterTimesUp++;
            switch (GameManager.instance.classicalBlasterTimesUp)
                {
                    case 1:
                        BlasterVariables.instance.UpgradeBlaster1Variables(0.2f,0.5f,1,10);
                        break;
                    
                    case 2:
                        BlasterVariables.instance.UpgradeBlaster1Variables(0.2f,0.5f,1,10);
                        break;
                    
                    case 3:
                        BlasterVariables.instance.UpgradeBlaster1Variables(0.2f,0.5f,1,10);
                        break;
                    
                    case 4:
                        BlasterVariables.instance.UpgradeBlaster1Variables(0.2f,0.5f,1,10);
                        break;
                    
                    case 5:
                        BlasterVariables.instance.UpgradeBlaster1Variables(0.2f,0.5f,1,10);
                        break;
                    
                    case 6:
                        BlasterVariables.instance.UpgradeBlaster1Variables(0.2f,0.5f,1,10);
                        break;
                    
                    case 7:
                        BlasterVariables.instance.UpgradeBlaster1Variables(0.2f,0.5f,1,10);
                        break;
                    
                    default:
                        break;
                }
        }
    }

  

    public void SelectFireBlaster()
    {
        if (GameManager.instance.plasmaBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[1]);
            BlasterVariables.instance.SetBlaster2Variables();

        }
    }
    

    public void UpgradeFireBlaster()
    {
        if (GameManager.instance.plasmaBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.plasmaBlasterCost)
        {
            GameManager.instance.plasmaBlaster = GameManager.instance.blasterList[1];
            GameManager.instance.getCoins() -= GameManager.instance.plasmaBlasterCost;
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.plasmaBlasterCost && GameManager.instance.plasmaBlasterTimesUp < 7)
        {
            GameManager.instance.plasmaBlaster = GameManager.instance.blasterList[1];
            GameManager.instance.getCoins() -= GameManager.instance.plasmaBlasterCost;
            GameManager.instance.plasmaBlasterCost *= 2;
            GameManager.instance.plasmaBlasterTimesUp++;
            
            switch (GameManager.instance.plasmaBlasterTimesUp) 
            {
                case 1:
                    BlasterVariables.instance.UpgradeBlaster2Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 2:
                    BlasterVariables.instance.UpgradeBlaster2Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 3:
                    BlasterVariables.instance.UpgradeBlaster2Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 4:
                    BlasterVariables.instance.UpgradeBlaster2Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 5:
                    BlasterVariables.instance.UpgradeBlaster2Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 6:
                    BlasterVariables.instance.UpgradeBlaster2Variables(0.2f,0.5f,1,10);
                    break;
                
                case 7:
                    BlasterVariables.instance.UpgradeBlaster2Variables(0.2f,0.5f,1,10);
                    break;
                
            }
        }
    }
    
    public void SelectIceBlaster()
    {
        if (GameManager.instance.iceBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[2]);
            BlasterVariables.instance.SetBlaster3Variables();

        }
    }
    
    public void UpgradeIceBlaster()
    {
        if (GameManager.instance.iceBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.iceBlasterCost)
        {
            GameManager.instance.iceBlaster = GameManager.instance.blasterList[2];
            GameManager.instance.getCoins() -= GameManager.instance.iceBlasterCost;
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.iceBlasterCost && GameManager.instance.iceBlasterTimesUp < 7)
        {
            GameManager.instance.iceBlaster = GameManager.instance.blasterList[2];
            GameManager.instance.getCoins() -= GameManager.instance.iceBlasterCost;
            GameManager.instance.iceBlasterTimesUp++;
            GameManager.instance.iceBlasterCost *= 2;
            
            switch (GameManager.instance.iceBlasterTimesUp)
            {
                case 1:
                    BlasterVariables.instance.UpgradeBlaster3Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 2:
                    BlasterVariables.instance.UpgradeBlaster3Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 3:
                    BlasterVariables.instance.UpgradeBlaster3Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 4:
                    BlasterVariables.instance.UpgradeBlaster3Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 5:
                    BlasterVariables.instance.UpgradeBlaster3Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 6:
                    BlasterVariables.instance.UpgradeBlaster3Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 7:
                    BlasterVariables.instance.UpgradeBlaster3Variables(0.2f,0.5f,1,10);
                    break;
                
            }
        }
    }
    
    public void SelectTransformationBlaster()
    {
        if (GameManager.instance.transformationBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[3]);
            BlasterVariables.instance.SetBlaster4Variables();


        }
    }

    public void UpgradeTransformationBlaster()
    {
        if (GameManager.instance.transformationBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.transformationBlasterCost)
        {
            GameManager.instance.transformationBlaster = GameManager.instance.blasterList[3];
            GameManager.instance.getCoins() -= GameManager.instance.plasmaBlasterCost;
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.transformationBlasterCost && GameManager.instance.transformationBlasterTimesUp < 7)
        {
            GameManager.instance.transformationBlaster = GameManager.instance.blasterList[3];
            GameManager.instance.getCoins() -= GameManager.instance.transformationBlasterCost;
            GameManager.instance.transformationBlasterCost *= 2;
            GameManager.instance.transformationBlasterTimesUp++;
            
            switch (GameManager.instance.transformationBlasterTimesUp) 
            {
                case 1:
                    BlasterVariables.instance.UpgradeBlaster4Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 2:
                    BlasterVariables.instance.UpgradeBlaster4Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 3:
                    BlasterVariables.instance.UpgradeBlaster4Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 4:
                    BlasterVariables.instance.UpgradeBlaster4Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 5:
                    BlasterVariables.instance.UpgradeBlaster4Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 6:
                    BlasterVariables.instance.UpgradeBlaster4Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 7:
                    BlasterVariables.instance.UpgradeBlaster4Variables(0.2f,0.5f,1,10);
                    break;
        
            }
        }
    }
    
    public void SelectLightBlaster()
    {
        if (GameManager.instance.lightBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[4]);
            BlasterVariables.instance.SetBlaster5Variables();

        }
    }

    public void UpgradeLightBlaster()
    {
      
        if (GameManager.instance.lightBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.lightBlasterCost)
        {
            GameManager.instance.lightBlaster = GameManager.instance.blasterList[4];
            GameManager.instance.getCoins() -= GameManager.instance.lightBlasterCost;
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.lightBlasterCost && GameManager.instance.lightBlasterTimesUp < 7)
        {
            GameManager.instance.lightBlaster = GameManager.instance.blasterList[4];
            
            GameManager.instance.getCoins() -= GameManager.instance.lightBlasterCost;
            GameManager.instance.lightBlasterCost *= 2;
            GameManager.instance.lightBlasterTimesUp++;
            
            switch (GameManager.instance.lightBlasterTimesUp) 
            {
                case 1:
                    BlasterVariables.instance.UpgradeBlaster5Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 2:
                    BlasterVariables.instance.UpgradeBlaster5Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 3:
                    BlasterVariables.instance.UpgradeBlaster5Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 4:
                    BlasterVariables.instance.UpgradeBlaster5Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 5:
                    BlasterVariables.instance.UpgradeBlaster5Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 6:
                    BlasterVariables.instance.UpgradeBlaster5Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 7:
                    BlasterVariables.instance.UpgradeBlaster5Variables(0.2f,0.5f,1,10);
                    break;
                
            }
        }
    }
    
    public void SelectForceBlaster()
    {
        if (GameManager.instance.forceBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[5]);
            BlasterVariables.instance.SetBlaster6Variables();

        }
    }

    public void UpgradeForceBlaster()
    {
        if (GameManager.instance.forceBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.forceBlasterCost)
        {
            GameManager.instance.forceBlaster = GameManager.instance.blasterList[5];
            GameManager.instance.getCoins() -= GameManager.instance.forceBlasterCost;
        }
        else if (GameManager.instance.getCoins() >= GameManager.instance.forceBlasterCost && GameManager.instance.voidBlasterTimesUp < 7)
        {
            GameManager.instance.forceBlaster = GameManager.instance.blasterList[5];
            GameManager.instance.getCoins() -= GameManager.instance.forceBlasterCost;
            GameManager.instance.forceBlasterTimesUp++;
            GameManager.instance.forceBlasterCost *= 2;
            

            switch (GameManager.instance.forceBlasterTimesUp) 
            {
                case 1:
                    BlasterVariables.instance.UpgradeBlaster6Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 2:
                    BlasterVariables.instance.UpgradeBlaster6Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 3:
                    BlasterVariables.instance.UpgradeBlaster6Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 4:
                    BlasterVariables.instance.UpgradeBlaster6Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 5:
                    BlasterVariables.instance.UpgradeBlaster6Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 6:
                    BlasterVariables.instance.UpgradeBlaster6Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 7:
                    BlasterVariables.instance.UpgradeBlaster6Variables(0.2f,0.5f,1,10);
                    break;
                
            }
        }
    }
    
    public void SelectVoidBlaster()
    {
        if (GameManager.instance.voidBlaster != null)
        {
            GameManager.instance.setBlasterType(GameManager.instance.blasterList[6]);
            BlasterVariables.instance.SetBlaster7Variables();

        }
    }

    public void UpgradeVoidBlaster()
    {
        if (GameManager.instance.voidBlaster == null && GameManager.instance.getCoins() >= GameManager.instance.voidBlasterCost)
        {
            GameManager.instance.voidBlaster = GameManager.instance.blasterList[6];
            GameManager.instance.getCoins() -= GameManager.instance.voidBlasterCost;
        }
        if (GameManager.instance.getCoins() >= GameManager.instance.voidBlasterCost && GameManager.instance.voidBlasterTimesUp < 7)
        {
            GameManager.instance.voidBlaster = GameManager.instance.blasterList[6];
            GameManager.instance.getCoins() -= GameManager.instance.voidBlasterCost;
            GameManager.instance.voidBlasterCost *= 2;
            
            
            switch (GameManager.instance.voidBlasterTimesUp) 
            {
                case 1:
                    BlasterVariables.instance.UpgradeBlaster7Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 2:
                    BlasterVariables.instance.UpgradeBlaster7Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 3:
                    BlasterVariables.instance.UpgradeBlaster7Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 4:
                    BlasterVariables.instance.UpgradeBlaster7Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 5:
                    BlasterVariables.instance.UpgradeBlaster7Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 6:
                    BlasterVariables.instance.UpgradeBlaster7Variables(0.2f,0.5f,1,10);
                    break;
                    
                case 7:
                    BlasterVariables.instance.UpgradeBlaster7Variables(0.2f,0.5f,1,10);
                    break;
            }
        }
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    
}
