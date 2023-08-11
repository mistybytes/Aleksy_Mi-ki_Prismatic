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
                        BlasterVariables.instance.UpgradeBlaster1Variables(2f,3.5f,1,20);
                        break;
                    
                    case 2:
                        BlasterVariables.instance.UpgradeBlaster1Variables(2.5f,3f,2,30);
                        break;
                    
                    case 3:
                        BlasterVariables.instance.UpgradeBlaster1Variables(3f,3f,2,40);
                        break;
                    
                    case 4:
                        BlasterVariables.instance.UpgradeBlaster1Variables(3.5f,2.6f,2,50);
                        break;
                    
                    case 5:
                        BlasterVariables.instance.UpgradeBlaster1Variables(4f,2.5f,3,60);
                        break;
                    
                    case 6:
                        BlasterVariables.instance.UpgradeBlaster1Variables(4.5f,2.3f,3,70);
                        break;
                    
                    case 7:
                        BlasterVariables.instance.UpgradeBlaster1Variables(5f,2f,3,80);
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
        
        //TODO make this weapon have a 25 percent chance to knock enemy back 
        
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
                    BlasterVariables.instance.UpgradeBlaster2Variables(3f,3.5f,1,90);
                    break;
                    
                case 2:
                    BlasterVariables.instance.UpgradeBlaster2Variables(3.5f,3.5f,1,100);
                    break;
                    
                case 3:
                    BlasterVariables.instance.UpgradeBlaster2Variables(4f,3.5f,2,110);
                    break;
                    
                case 4:
                    BlasterVariables.instance.UpgradeBlaster2Variables(4f,3f,2,120);
                    break;
                    
                case 5:
                    BlasterVariables.instance.UpgradeBlaster2Variables(4.5f,3f,2,130);
                    break;
                    
                case 6:
                    BlasterVariables.instance.UpgradeBlaster2Variables(5f,2.5f,2,140);
                    break;
                
                case 7:
                    BlasterVariables.instance.UpgradeBlaster2Variables(5f,2f,3,150);
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
                    BlasterVariables.instance.UpgradeBlaster3Variables(2f,2.5f,1,160);
                    break;
                    
                case 2:
                    BlasterVariables.instance.UpgradeBlaster3Variables(2.5f,2.5f,2,170);
                    break;
                    
                case 3:
                    BlasterVariables.instance.UpgradeBlaster3Variables(3f,2.2f,2,180);
                    break;
                    
                case 4:
                    BlasterVariables.instance.UpgradeBlaster3Variables(3.5f,2.2f,2,190);
                    break;
                    
                case 5:
                    BlasterVariables.instance.UpgradeBlaster3Variables(4f,2f,2,200);
                    break;
                    
                case 6:
                    BlasterVariables.instance.UpgradeBlaster3Variables(4f,2f,3,210);
                    break;
                    
                case 7:
                    BlasterVariables.instance.UpgradeBlaster3Variables(4.5f,2f,3,220);
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
            GameManager.instance.getCoins() -= GameManager.instance.transformationBlasterCost;
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
                    BlasterVariables.instance.UpgradeBlaster4Variables(3.5f,4f,1,230);
                    break;
                    
                case 2:
                    BlasterVariables.instance.UpgradeBlaster4Variables(3.5f,4f,1,240);
                    break;
                    
                case 3:
                    BlasterVariables.instance.UpgradeBlaster4Variables(3.5f,4f,1,250);
                    break;
                    
                case 4:
                    BlasterVariables.instance.UpgradeBlaster4Variables(4f,4f,2,260);
                    break;
                    
                case 5:
                    BlasterVariables.instance.UpgradeBlaster4Variables(4f,3.5f,2,270);
                    break;
                    
                case 6:
                    BlasterVariables.instance.UpgradeBlaster4Variables(4f,3.5f,2,280);
                    break;
                    
                case 7:
                    BlasterVariables.instance.UpgradeBlaster4Variables(4f,3f,3,290);
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
                    BlasterVariables.instance.UpgradeBlaster5Variables(4f,2f,1,100);
                    break;
                    
                case 2:
                    BlasterVariables.instance.UpgradeBlaster5Variables(4.3f,1.9f,1,150);
                    break;
                    
                case 3:
                    BlasterVariables.instance.UpgradeBlaster5Variables(4.5f,1.8f,1,150);
                    break;
                    
                case 4:
                    BlasterVariables.instance.UpgradeBlaster5Variables(4.7f,1.7f,1,200);
                    break;
                    
                case 5:
                    BlasterVariables.instance.UpgradeBlaster5Variables(4.5f,1.6f,1,200);
                    break;
                    
                case 6:
                    BlasterVariables.instance.UpgradeBlaster5Variables(5f,1.5f,1,200);
                    break;
                    
                case 7:
                    BlasterVariables.instance.UpgradeBlaster5Variables(5.5f,0.7f,1,200);
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
        
        //TODO make this blaster summon a bullet around the player that will defend him
        //it should move in a direction countering the movement of the player
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
                    BlasterVariables.instance.UpgradeBlaster6Variables(3f,5f,1,370);
                    break;
                    
                case 2:
                    BlasterVariables.instance.UpgradeBlaster6Variables(3f,5f,2,380);
                    break;
                    
                case 3:
                    BlasterVariables.instance.UpgradeBlaster6Variables(3f,5f,3,390);
                    break;
                    
                case 4:
                    BlasterVariables.instance.UpgradeBlaster6Variables(3f,4.5f,4,400);
                    break;
                    
                case 5:
                    BlasterVariables.instance.UpgradeBlaster6Variables(3f,4.5f,5,410);
                    break;
                    
                case 6:
                    BlasterVariables.instance.UpgradeBlaster6Variables(3.5f,4f,5,420);
                    break;
                    
                case 7:
                    BlasterVariables.instance.UpgradeBlaster6Variables(4f,3f,5,430);
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
        //TODO make the boss take 7 hits to be killed speeding him up with every hit
        
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
                    BlasterVariables.instance.UpgradeBlaster7Variables(4f,0.5f,1,10);
                    break;
                    
                case 2:
                    BlasterVariables.instance.UpgradeBlaster7Variables(4f,0.5f,1,10);
                    break;
                    
                case 3:
                    BlasterVariables.instance.UpgradeBlaster7Variables(4f,0.5f,1,10);
                    break;
                    
                case 4:
                    BlasterVariables.instance.UpgradeBlaster7Variables(4f,0.5f,1,10);
                    break;
                    
                case 5:
                    BlasterVariables.instance.UpgradeBlaster7Variables(4f,0.5f,1,10);
                    break;
                    
                case 6:
                    BlasterVariables.instance.UpgradeBlaster7Variables(4f,0.5f,1,10);
                    break;
                    
                case 7:
                    BlasterVariables.instance.UpgradeBlaster7Variables(4f,0.5f,1,10);
                    break;
            }
        }
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    
}
