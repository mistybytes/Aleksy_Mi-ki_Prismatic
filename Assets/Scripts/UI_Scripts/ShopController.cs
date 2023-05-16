using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShopController : MonoBehaviour
{
   
    [SerializeField] 
    private GameObject[] blasterTypes = new GameObject[7];
    
    private int damageCost = 10;
    private int shotSpeedCost = 10;
    private int playerSpeedCost = 10;
    
    private int _fireBlasterCost = 100;
    private int _iceBlasterCost = 200;
    private int _transformationBlasterCost = 300;
    private int _lighBlasterCost = 400;
    private int _forceBlasterCost = 500;
    private int _voidBlasterCost = 600;
    
    private GameObject selectedBlaster;
    
    public void BulletDamage()
    {
        if (GameManager.instance.getCoins() > damageCost)
        {
            GameManager.instance.getCoins() -= damageCost;
            damageCost  *= 5;
            GameManager.instance.upgradeShotDamage();
        }
    }
    
    public void ShotSpeed()
    {
        if (GameManager.instance.getCoins() > shotSpeedCost)
        {
            GameManager.instance.getCoins() -= shotSpeedCost;
            shotSpeedCost  *= 5;
            GameManager.instance.upgradeShotSpeed();
        }
    }

    public void PlayerSpeed()
    {
        if (GameManager.instance.getCoins() > playerSpeedCost)
        {
            GameManager.instance.getCoins() -= shotSpeedCost;
            shotSpeedCost  *= 5;
            GameManager.instance.upgradePlayerSpeed();
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
            if (GameManager.instance.getCoins() > _iceBlasterCost)
            {   
                GameManager.instance._iceBlaster = blasterTypes[2];
                GameManager.instance.setBlasterType(blasterTypes[2]);
            }
        }
    }

    public void upgradeIceBlaster()
    {
        if (GameManager.instance.getCoins() > _iceBlasterCost)
        {
            _iceBlasterCost = _iceBlasterCost * 2;
            GameManager.instance._iceBlaster.GetComponent<IceBlaster>().upgradeFreeze();
            GameManager.instance.getCoins() -= _iceBlasterCost;
            
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
            if (GameManager.instance.getCoins() > _fireBlasterCost)
            {
                GameManager.instance._plasmaBlaster = blasterTypes[1];
                GameManager.instance.setBlasterType(blasterTypes[1]);
            }
        }
    }

    public void upgradeFireBlaster()
    {
        if (GameManager.instance.getCoins() > _fireBlasterCost)
        {
            _fireBlasterCost = _fireBlasterCost * 2;
            GameManager.instance._plasmaBlaster.GetComponent<PlasmaBlasterProjectile>().fireDuration += 0.5f;
            GameManager.instance._plasmaBlaster.GetComponent<PlasmaBlasterProjectile>().fireDamagePerSecond += 5;
            GameManager.instance.getCoins() -= _fireBlasterCost;
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
            if (GameManager.instance.getCoins() > _transformationBlasterCost)
            {
                GameManager.instance._transformationBlaster = blasterTypes[3];
                GameManager.instance.setBlasterType(blasterTypes[3]);
            }
        }
    }

    public void upgradeTransformationBlaster()
    {
        if (GameManager.instance.getCoins() > _transformationBlasterCost)
        {
            _transformationBlasterCost = _transformationBlasterCost * 2;
            GameManager.instance._transformationBlaster.GetComponent<TransformingBlaster>().transformChance += 0.05f;
            GameManager.instance.getCoins() -= _transformationBlasterCost;
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
            if (GameManager.instance.getCoins() > _lighBlasterCost)
            {
                GameManager.instance._lightBlaster = blasterTypes[4];
                GameManager.instance.setBlasterType(blasterTypes[4]);
            }
        }
    }

    public void upgradeLightBlaster()
    {
        //shot speed higher for this blaster, but lower damage and the player is faster
        if (GameManager.instance.getCoins() > _lighBlasterCost)
        {
            _lighBlasterCost = _lighBlasterCost * 2;
            GameManager.instance.getCoins() -= _lighBlasterCost;
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
            if (GameManager.instance.getCoins() > _forceBlasterCost)
            {
                GameManager.instance._forceBlaster = blasterTypes[5];
                GameManager.instance.setBlasterType(blasterTypes[5]);
            }
        }
    }

    public void upgradeForceBlaster()
    {
        if (GameManager.instance.getCoins() > _forceBlasterCost)
        {
            //there is extra health for this blaster
            _forceBlasterCost = _forceBlasterCost * 2;
            GameManager.instance.getCoins() -= _forceBlasterCost;
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
            if (GameManager.instance.getCoins() > _voidBlasterCost)
            {
                GameManager.instance._voidBlaster = blasterTypes[6];
                GameManager.instance.setBlasterType(blasterTypes[6]);
            }
        }
    }

    public void upgradeVoidBlaster()
    {
        if (GameManager.instance.getCoins() > _voidBlasterCost)
        {
            _voidBlasterCost = _voidBlasterCost * 2;
            GameManager.instance.getCoins() -= _voidBlasterCost;
        }
    }
    
    
    
}
