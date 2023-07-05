using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DailyRewards : MonoBehaviour
{
    
    private DateTime lastRewardTime;

    void Awake() {
        string timeString = PlayerPrefs.GetString("LastRewardTime", DateTime.Now.ToString());
        DateTime lastRewardTime = DateTime.Parse(timeString);
        // Load the last reward time from PlayerPrefs
        string savedTime = PlayerPrefs.GetString("LastRewardTime");
        if (string.IsNullOrEmpty(savedTime)) {
            // If there's no saved time, use the current time
            lastRewardTime = DateTime.Now;
        } else {
            // If there is a saved time, parse it
            lastRewardTime = DateTime.Parse(savedTime);
        }
    }

    public void Update() {
        
        if (DateTime.Now > lastRewardTime.AddHours(24)) {
         
            GiveReward();
            lastRewardTime = DateTime.Now;
            
            PlayerPrefs.SetString("LastRewardTime", lastRewardTime.ToString());
            PlayerPrefs.Save();
        }
    }

    private void GiveReward() {
        
        DateTime now = DateTime.Now;
        PlayerPrefs.SetString("LastRewardTime", now.ToString());
       
    }
}