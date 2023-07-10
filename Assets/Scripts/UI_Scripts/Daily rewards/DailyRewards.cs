using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DailyRewards : MonoBehaviour
{
    public static DailyRewards Instance;

    private string consecutiveDaysPrefs = "ConsecutiveDays";
    private string coinTotalPrefs = "CoinTotal";

    private string lastRewardTimePrefs = "LastRewardTime";

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public bool CanGetReward()
    {
        if (!PlayerPrefs.HasKey(lastRewardTimePrefs))
        {
            return true;
        }

        string lastRewardTime = PlayerPrefs.GetString(lastRewardTimePrefs);
        DateTime lastRewardDateTime = DateTime.Parse(lastRewardTime);

        if (DateTime.Now > lastRewardDateTime.AddDays(1))
        {
            // If more than two days have passed, reset the counter
            if (DateTime.Now > lastRewardDateTime.AddDays(2))
            {
                PlayerPrefs.SetInt(consecutiveDaysPrefs, 0);
            }

            return true;
        }

        return false;
    }

    public void GetReward()
    {
        
        int consecutiveDays = PlayerPrefs.GetInt(consecutiveDaysPrefs, 0) + 1;
        
        if (consecutiveDays % 7 == 0)
        {
            GameManager.instance.setCoins(GameManager.instance.getCoins() + 200);
        }
        else
        {
            GameManager.instance.setCoins(GameManager.instance.getCoins() + 200);
        }

        PlayerPrefs.SetInt(coinTotalPrefs, GameManager.instance.getCoins());
        PlayerPrefs.SetInt(consecutiveDaysPrefs, consecutiveDays);
        
        PlayerPrefs.SetString(lastRewardTimePrefs, DateTime.Now.ToString());

        Debug.Log($"Player received daily reward! They now have {GameManager.instance.getCoins()} coins and have logged in {consecutiveDays} days in a row.");
    }
    
    public void exitToMM()
    {
        SceneManager.LoadScene("MainMenu");
    }

}