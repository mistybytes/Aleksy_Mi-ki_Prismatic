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
            }
        }
    }

    public void upgradeIceBlaster()
    {
        
    }
}
