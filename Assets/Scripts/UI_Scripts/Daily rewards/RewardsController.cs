using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RewardsController : MonoBehaviour
{
    // Start is called before the first frame update
    public void GetReward()
    {
     
            Debug.Log("clicked");

            int consecutiveDays = PlayerPrefs.GetInt(DailyRewards.Instance.consecutiveDaysPrefs, 0) + 1;

            if (consecutiveDays % 7 == 0)
            {
                GameManager.instance.setCoins(GameManager.instance.getCoins() + 200);
            }
            else
            {
                GameManager.instance.setCoins(GameManager.instance.getCoins() + 200);
            }

            PlayerPrefs.SetInt(DailyRewards.Instance.coinTotalPrefs, GameManager.instance.getCoins());
            PlayerPrefs.SetInt(DailyRewards.Instance.consecutiveDaysPrefs, consecutiveDays);

            PlayerPrefs.SetString(DailyRewards.Instance.lastRewardTimePrefs, DateTime.Now.ToString());
    }

    public void rewardsInfo()
    {
        SceneManager.LoadScene("RewardsInfo");
    }
    
    
    
}
