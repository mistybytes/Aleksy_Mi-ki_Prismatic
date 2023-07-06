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
     
        string savedTime = PlayerPrefs.GetString("LastRewardTime");
        if (string.IsNullOrEmpty(savedTime)) {
          
            lastRewardTime = DateTime.Now;
        } else {
         
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