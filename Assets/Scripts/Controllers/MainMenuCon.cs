using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCon : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void SkinSelect()
    {
        SceneManager.LoadScene("SkinSelect");
    }

    public void UpgradeShop()
    {
        SceneManager.LoadScene("PowerUpStore");
    }

    public void Settings()
    {
        SceneManager.LoadScene("SETTINGS");
    }

    public void Rewards()
    {
        SceneManager.LoadScene("DailyRewards");
    }

    public void BuffsShop()
    {
        SceneManager.LoadScene("BuffsShop");
    }
}
