using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShopController : MonoBehaviour
{
    public void Start()
    {
        if (!GameManager.instance.sc)
        {
            GameManager.instance.sc = this;
            
            for (var i = 0; i < GameManager.instance.classicalBlasterTimesUp; i++)
            {
                upgradeBlaster();
            }

            for (var i = 0; i < GameManager.instance.plasmaBlasterTimesUp; i++)
            {
                upgradeFireBlaster();
            }

            for (var i = 0; i < GameManager.instance.iceBlasterTimesUp; i++)
            {
                upgradeIceBlaster();
            }

            for (var i = 0; i < GameManager.instance.transformationBlasterTimesUp; i++)
            {
                upgradeTransformationBlaster();
            }

            for (var i = 0; i < GameManager.instance.lightBlasterTimesUp; i++)
            {
                upgradeLightBlaster();
            }

            for (var i = 0; i < GameManager.instance.forceBlasterTimesUp; i++)
            {
                upgradeForceBlaster();
            }

            for (var i = 0; i < GameManager.instance.voidBlasterTimesUp; i++)
            {
                upgradeVoidBlaster();
            }

            DontDestroyOnLoad(gameObject);
        }
    }



    public void selectBlaster()
    {
        GameManager.instance.setBlasterType(GameManager.instance.classicalBlaster);
        GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().setVariables();
    }

    public void upgradeBlaster()
    {
        if (GameManager.instance.getCoins() >= GameManager.instance.classicalBlasterCost && GameManager.instance.classicalBlasterTimesUp < 7)
            {
                GameManager.instance.getCoins() -= GameManager.instance.classicalBlasterCost;
                GameManager.instance.classicalBlasterCost *= 2;
                GameManager.instance.classicalBlasterTimesUp++;
                GameManager.instance.classicalBlaster.GetComponent<Projectile1>().upgradeBlaster1();
                
                switch (GameManager.instance.classicalBlasterTimesUp)
                {
                    case 1:
                        GameManager.instance.classicalBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0f, 0, 0);
                        break;
                    
                    case 2:
                        GameManager.instance.classicalBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                        break;
                    
                    case 3:
                        GameManager.instance.classicalBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                        break;
                    
                    case 4:
                        GameManager.instance.classicalBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                        break;
                    
                    case 5:
                        GameManager.instance.classicalBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                        break;
                    
                    case 6:
                        GameManager.instance.classicalBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                        break;
                    
                    case 7:
                        GameManager.instance.classicalBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                        break;
                    
                    default:
                        break;
                }
            }
        
    }

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
        else if (GameManager.instance.getCoins() >= GameManager.instance.plasmaBlasterCost && GameManager.instance.plasmaBlasterTimesUp < 7)
        {
            GameManager.instance.plasmaBlaster = GameManager.instance.blasterList[1];
            GameManager.instance.getCoins() -= GameManager.instance.plasmaBlasterCost;
            GameManager.instance.plasmaBlasterCost *= 2;
            GameManager.instance.plasmaBlasterTimesUp++;
            
            GameManager.instance.plasmaBlaster.GetComponent<Projectile2>().upgradeBlaster2();
            
            switch (GameManager.instance.plasmaBlasterTimesUp) 
            {
                case 1:
                    GameManager.instance.plasmaBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                    break;
                    
                case 2:
                    GameManager.instance.plasmaBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                    break;
                    
                case 3:
                    GameManager.instance.plasmaBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                    break;
                    
                case 4:
                    GameManager.instance.plasmaBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                    break;
                    
                case 5:
                    GameManager.instance.plasmaBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                    break;
                    
                case 6:
                    GameManager.instance.plasmaBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                    break;
                    
                case 7:
                    GameManager.instance.plasmaBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                    break;
                    
                default:
                    break;
            }
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
        else if (GameManager.instance.getCoins() >= GameManager.instance.iceBlasterCost && GameManager.instance.iceBlasterTimesUp < 7)
        {
            GameManager.instance.iceBlaster = GameManager.instance.blasterList[2];
            GameManager.instance.getCoins() -= GameManager.instance.iceBlasterCost;
            GameManager.instance.iceBlasterTimesUp++;
            GameManager.instance.iceBlasterCost *= 2;
            
            GameManager.instance.iceBlaster.GetComponent<Projectile3>().upgradeBlaster3(); 
            
            switch (GameManager.instance.iceBlasterTimesUp)
            {
                case 1:
                    GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                    break;
                    
                case 2:
                    GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                    break;
                    
                case 3:
                    GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                    break;
                    
                case 4:
                    GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                    break;
                    
                case 5:
                    GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                    break;
                    
                case 6:
                    GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                    break;
                    
                case 7:
                    GameManager.instance.selectedBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                    break;
                    
                default:
                    break;
            }
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
        else if (GameManager.instance.getCoins() >= GameManager.instance.transformationBlasterCost && GameManager.instance.transformationBlasterTimesUp < 7)
        {
            GameManager.instance.transformationBlaster = GameManager.instance.blasterList[3];
            GameManager.instance.getCoins() -= GameManager.instance.transformationBlasterCost;
            GameManager.instance.transformationBlasterCost *= 2;
            GameManager.instance.transformationBlasterTimesUp++;
            
            GameManager.instance.transformationBlaster.GetComponent<Projectile4>().upgradeBlaster4();
            
            switch (GameManager.instance.transformationBlasterTimesUp) 
            {
                case 1:
                GameManager.instance.transformationBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 2:
                GameManager.instance.transformationBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 3:
                GameManager.instance.transformationBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 4:
                GameManager.instance.transformationBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 5:
                GameManager.instance.transformationBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 6:
                GameManager.instance.transformationBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 7:
                GameManager.instance.transformationBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                default:
                break;
            }
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
        else if (GameManager.instance.getCoins() >= GameManager.instance.lightBlasterCost && GameManager.instance.lightBlasterTimesUp < 7)
        {
            GameManager.instance.lightBlaster = GameManager.instance.blasterList[4];
            
            GameManager.instance.getCoins() -= GameManager.instance.lightBlasterCost;
            GameManager.instance.lightBlasterCost *= 2;
            GameManager.instance.lightBlasterTimesUp++;
            
            GameManager.instance.lightBlaster.GetComponent<Projectile5>().upgradeBlaster5();
            
            switch (GameManager.instance.lightBlasterTimesUp) 
            {
                case 1:
                GameManager.instance.lightBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 2:
                GameManager.instance.lightBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 3:
                GameManager.instance.lightBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 4:
                GameManager.instance.lightBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 5:
                GameManager.instance.lightBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 6:
                GameManager.instance.lightBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 7:
                GameManager.instance.lightBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                default:
                break;
            }
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
        else if (GameManager.instance.getCoins() >= GameManager.instance.forceBlasterCost && GameManager.instance.voidBlasterTimesUp < 7)
        {
            GameManager.instance.forceBlaster = GameManager.instance.blasterList[5];
            GameManager.instance.getCoins() -= GameManager.instance.forceBlasterCost;
            GameManager.instance.forceBlasterTimesUp++;
            GameManager.instance.forceBlasterCost *= 2;
            
            GameManager.instance.forceBlaster.GetComponent<Projectile6>().upgradeBlaster6();

            switch (GameManager.instance.forceBlasterTimesUp) 
            {
                case 1:
                GameManager.instance.forceBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 2:
                GameManager.instance.forceBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 3:
                GameManager.instance.forceBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 4:
                GameManager.instance.forceBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 5:
                GameManager.instance.forceBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 6:
                GameManager.instance.forceBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 7:
                GameManager.instance.forceBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                default:
                break;
            }
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
        if (GameManager.instance.getCoins() >= GameManager.instance.voidBlasterCost && GameManager.instance.voidBlasterTimesUp < 7)
        {
            GameManager.instance.voidBlaster = GameManager.instance.blasterList[6];
            GameManager.instance.getCoins() -= GameManager.instance.voidBlasterCost;
            GameManager.instance.voidBlasterCost *= 2;
            
            GameManager.instance.voidBlaster.GetComponent<Projectile7>().upgradeBlaster7();
            
            switch (GameManager.instance.voidBlasterTimesUp) 
            {
                case 1:
                GameManager.instance.voidBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 2:
                GameManager.instance.voidBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 3:
                GameManager.instance.voidBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 4:
                GameManager.instance.voidBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 5:
                GameManager.instance.voidBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 6:
                GameManager.instance.voidBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                case 7:
                GameManager.instance.voidBlaster.GetComponent<BlasterVariables>().upgradeBlasterVariables(0.4f, 1, 1);
                break;
                    
                default:
                break;
            }
        }
    }
    
    
    
}
