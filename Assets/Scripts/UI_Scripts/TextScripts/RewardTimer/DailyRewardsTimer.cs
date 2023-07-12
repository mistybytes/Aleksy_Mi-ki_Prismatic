using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DailyRewardsTimer : MonoBehaviour
{
    public Text timerText;

    private void Start()
    {
        timerText = GetComponent<Text>();
    }

    private void Update()
    {
        if (DailyRewards.Instance.CanGetReward())
        {
            timerText.text = "Reward available ! ";
        }
        else
        {
            string lastRewardTime = PlayerPrefs.GetString("LastRewardTime","10:10:10");
            
            DateTime lastRewardDateTime = DateTime.Parse(lastRewardTime);

            TimeSpan timeUntilNextReward = lastRewardDateTime.AddDays(1) - DateTime.Now;
            
            string timerString = string.Format("{0:D2}:{1:D2}:{2:D2}", timeUntilNextReward.Hours, timeUntilNextReward.Minutes, timeUntilNextReward.Seconds);
            timerText.text = "Next reward in: " + timerString;
        }
    }
    
}