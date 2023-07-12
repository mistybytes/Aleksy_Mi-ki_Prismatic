using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DailyRewards : MonoBehaviour
{
    public static DailyRewards Instance;

    public string consecutiveDaysPrefs = "ConsecutiveDays";
    public string coinTotalPrefs = "CoinTotal";

    public string lastRewardTimePrefs = "LastRewardTime";

    void Start()
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
            if (DateTime.Now > lastRewardDateTime.AddDays(2))
            {
                PlayerPrefs.SetInt(consecutiveDaysPrefs, 0);
            }
            return true;
        }

        return false;
    }
    
   
    

}