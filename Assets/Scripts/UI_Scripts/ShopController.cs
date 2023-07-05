using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShopController : MonoBehaviour
{
   
    [SerializeField] 
    private GameObject[] blasterTypes = new GameObject[7];
    
    
    public int shotSpeedCost = 10;
    public int playerSpeedCost = 10;
    
    public int _classicalBlasterCost = 10;
    public int classicalBlasterUpgraded;
    public int _fireBlasterCost = 100;
    public int fireBlasterUpgraded;
    public int _iceBlasterCost = 200;
    public int iceBlasterUpgraded;
    public int _forceBlasterCost = 300;
    public int forceBlasterUpgraded = 0;
    public int _lighBlasterCost = 400;
    public int lightBlasterUpgraded = 0;
    public int _transformationBlasterCost = 500;
    public int transformationBlasterUpgraded = 0;
    public int _voidBlasterCost = 600;
    public int voidBlasterUpgraded = 0;
    
    
    private GameObject selectedBlaster;

    private void Start()
    {
        //dopisać tutaj player prefs i dowiedzieć się dlaczego redundant
    }

    public void selectBlaster()
    {
        GameManager.instance.setBlasterType(blasterTypes[0]);
    }

    public void upgradeBlaster()
    {
        if (GameManager.instance.getCoins() >= _classicalBlasterCost)
        {
            
            GameManager.instance._classicalBlaster.GetComponent<BlasterVariables>().damage += 5;
            GameManager.instance.getCoins() -= _classicalBlasterCost;
            _classicalBlasterCost = _classicalBlasterCost * 2;
            classicalBlasterUpgraded++;
        }
    }
    

    public void backToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void selectIceBlaster()
    {
        if (GameManager.instance._iceBlaster != null)
        {
            GameManager.instance.setBlasterType(blasterTypes[2]);
        }
        else
        {
            if (GameManager.instance.getCoins() >= _iceBlasterCost)
            {   
                GameManager.instance._iceBlaster = blasterTypes[2];
                GameManager.instance.setBlasterType(blasterTypes[2]);
            }
        }
    }

    public void upgradeIceBlaster()
    {
        if (GameManager.instance.getCoins() >= _iceBlasterCost)
        {
            
            if(GameManager.instance._iceBlaster)
                iceBlasterUpgraded++;
            GameManager.instance._iceBlaster = blasterTypes[2];
            GameManager.instance.setBlasterType(blasterTypes[2]);
            GameManager.instance._iceBlaster.GetComponent<IceBlaster>().upgradeFreeze();
            GameManager.instance.getCoins() -= _iceBlasterCost;

            
            _iceBlasterCost = _iceBlasterCost * 2;
            
        }
    }
    
    public void selectFireBlaster()
    {
        if (GameManager.instance._plasmaBlaster != null)
        {
            GameManager.instance.setBlasterType(blasterTypes[1]);
        }
        else
        {
            if (GameManager.instance.getCoins() >= _fireBlasterCost)
            {
                GameManager.instance.getCoins() -= _fireBlasterCost;
                GameManager.instance._plasmaBlaster = blasterTypes[1];
                GameManager.instance.setBlasterType(blasterTypes[1]);
            }
        }
    }
    
    public void upgradeFireBlaster()
    {
        if (GameManager.instance.getCoins() >= _fireBlasterCost)
        {
           
            GameManager.instance._plasmaBlaster = blasterTypes[1];
            GameManager.instance.setBlasterType(blasterTypes[1]);
            GameManager.instance._plasmaBlaster.GetComponent<PlasmaBlasterProjectile>().fireDuration += 0.5f;
            GameManager.instance._plasmaBlaster.GetComponent<PlasmaBlasterProjectile>().fireDamagePerSecond += 5;
            GameManager.instance.getCoins() -= _fireBlasterCost;
            fireBlasterUpgraded++;
            _fireBlasterCost = _fireBlasterCost * 2;
        }
    }
    
    public void selectTransformationBlaster()
    {
        if (GameManager.instance._transformationBlaster != null)
        {
            GameManager.instance.setBlasterType(blasterTypes[3]);
        }
        else
        {
            if (GameManager.instance.getCoins() >= _transformationBlasterCost)
            {
                GameManager.instance._transformationBlaster = blasterTypes[3];
                GameManager.instance.setBlasterType(blasterTypes[3]);
            }
        }
    }

    public void upgradeTransformationBlaster()
    {
        if (GameManager.instance.getCoins() >= _transformationBlasterCost)
        {
            GameManager.instance._transformationBlaster = blasterTypes[3];
            GameManager.instance.setBlasterType(blasterTypes[3]);
            GameManager.instance._transformationBlaster.GetComponent<TransformingBlaster>().transformChance += 0.05f;
            GameManager.instance.getCoins() -= _transformationBlasterCost;
            transformationBlasterUpgraded++;
            _transformationBlasterCost = _transformationBlasterCost * 2;
        }
    }
    
    public void selectLightBlaster()
    {
        if (GameManager.instance._lightBlaster != null)
        {
            GameManager.instance.setBlasterType(blasterTypes[4]);
        }
        else
        {
            if (GameManager.instance.getCoins() >= _lighBlasterCost)
            {
                GameManager.instance._lightBlaster = blasterTypes[4];
                GameManager.instance.setBlasterType(blasterTypes[4]);
            }
        }
    }

    public void upgradeLightBlaster()
    {
      
        if (GameManager.instance.getCoins() >= _lighBlasterCost)
        {
            
            GameManager.instance._lightBlaster = blasterTypes[4];
            GameManager.instance.setBlasterType(blasterTypes[4]);
            GameManager.instance.getCoins() -= _lighBlasterCost;
            lightBlasterUpgraded++;
            _lighBlasterCost = _lighBlasterCost * 2;
        }
    }
    
    public void selectForceBlaster()
    {
        if (GameManager.instance._forceBlaster != null)
        {
            GameManager.instance.setBlasterType(blasterTypes[5]);
        }
        else
        {
            if (GameManager.instance.getCoins() >= _forceBlasterCost)
            {
                GameManager.instance._forceBlaster = blasterTypes[5];
                GameManager.instance.setBlasterType(blasterTypes[5]);
            }
        }
    }

    public void upgradeForceBlaster()
    {
        if (GameManager.instance.getCoins() >= _forceBlasterCost)
        {
            //there is extra health for this blaster
            
            GameManager.instance._forceBlaster = blasterTypes[5];
            GameManager.instance.setBlasterType(blasterTypes[5]);
            GameManager.instance.getCoins() -= _forceBlasterCost;
            forceBlasterUpgraded++;
            _forceBlasterCost = _forceBlasterCost * 2;
        }
    }
    
    public void selectVoidBlaster()
    {
        if (GameManager.instance._voidBlaster != null)
        {
            GameManager.instance.setBlasterType(blasterTypes[6]);
        }
        else
        {
            if (GameManager.instance.getCoins() >= _voidBlasterCost)
            {
                GameManager.instance._voidBlaster = blasterTypes[6];
                GameManager.instance.setBlasterType(blasterTypes[6]);
            }
        }
    }

    public void upgradeVoidBlaster()
    {
        if (GameManager.instance.getCoins() >= _voidBlasterCost)
        {
            if(GameManager.instance._voidBlaster)
                voidBlasterUpgraded++;
            
            GameManager.instance._voidBlaster = blasterTypes[6];
            GameManager.instance.setBlasterType(blasterTypes[6]);
            GameManager.instance.getCoins() -= _voidBlasterCost;
            
            _voidBlasterCost = _voidBlasterCost * 2;
        }
    }
    
    
    
}
