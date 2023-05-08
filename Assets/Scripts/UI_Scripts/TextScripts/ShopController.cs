using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShopController : MonoBehaviour
{
    // Start is called before the first frame update
    public void BulletDamage()
    {
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
