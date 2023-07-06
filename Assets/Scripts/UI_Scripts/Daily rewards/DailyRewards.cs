using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DailyRewards : MonoBehaviour
{

    
    [SerializeField]
    private Text textField;
    
    private DateTime lastRewardTime;
    private bool rewardCollected;
    
    void Start()
    {
        textField = GetComponent<Text>();
        
        if (PlayerPrefs.GetInt("rewardCollected") == 1)
        {
            rewardCollected = true;
        }
        else
        {
            rewardCollected = false;
        }
        
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

        textField.text = "TIME UNTIL NEXT REWARD : " + timeDisplay;
        
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
            
            GameManager.instance.setCoins(GameManager.instance.getCoins() + 10);
        }
    }

    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}