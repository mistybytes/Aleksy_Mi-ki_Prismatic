using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DailyRewards : MonoBehaviour
{
    
    private DateTime lastRewardTime;
    private bool rewardCollected;
    private int rewardDay;

    private int[] rewards = new int[7]; 
    void Save()
    {
        PlayerPrefs.SetString("lastRewardTime",lastRewardTime.ToString());
        PlayerPrefs.SetInt("rewardDay", rewardDay);
    }
    
    void Start()
    {
        for (int i = 0; i < 7; i++)
        {
            rewards[i] = 10;
        }

        if (PlayerPrefs.GetInt("rewardCollected") == 1)
        {
            rewardCollected = true;
        }
        else
        {
            rewardCollected = false;
        }

        rewardDay = PlayerPrefs.GetInt("rewardDay");
        
        var timeString = PlayerPrefs.GetString("LastRewardTime", DateTime.Now.ToString());
        DateTime lastRewardTime = DateTime.Parse(timeString);
        var savedTime = PlayerPrefs.GetString("LastRewardTime");
        if (string.IsNullOrEmpty(savedTime)) {
            lastRewardTime = DateTime.Now;
        } else {
         
            lastRewardTime = DateTime.Parse(savedTime);
        }
    }

    public void Update() {
        
        TimeSpan timeDiff = lastRewardTime.AddHours(24) - DateTime.Now;
        string timeDisplay = String.Format("{0}:{1}:{2}", timeDiff.Hours, timeDiff.Minutes, timeDiff.Seconds);

 
        if (DateTime.Now > lastRewardTime.AddHours(24))
        {
           
            rewardCollected = false;
            lastRewardTime = DateTime.Now;
            
            PlayerPrefs.SetString("LastRewardTime", lastRewardTime.ToString());
            PlayerPrefs.Save();
        }
    }

    public void GiveReward() {

        if (DateTime.Now > lastRewardTime.AddHours(24) && rewardCollected == false)
        {
            DateTime now = DateTime.Now;
            PlayerPrefs.SetString("LastRewardTime", now.ToString());
            
            rewardCollected = true;
            
            //TODO make this better and add better rewards
            GameManager.instance.setCoins(GameManager.instance.getCoins() + rewards[rewardDay]);
            rewardDay++;
            if (rewardDay == 6)
            {
                GameManager.instance.setCoins(GameManager.instance.getCoins() + 100);
                rewardDay = 0;
            }
        }
    }
    
    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}