using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShopController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] 
    private GameObject[] blasterTypes = new GameObject[3];
    
    public void BulletDamage()
    {
        GameManager.instance.setBlasterType(blasterTypes[0]);
        GameManager.instance.upgradeShotDamage();
    }

    // Update is called once per frame
    public void ShotSpeed()
    {
        GameManager.instance.upgradeShotSpeed();
    }

    public void PlayerSpeed()
    {
        GameManager.instance.upgradePlayerSpeed();
    }

    public void backToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
