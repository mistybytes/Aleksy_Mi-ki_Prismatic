using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DaysInARow : MonoBehaviour
{
    // Start is called before the first frame update
    private Text textComponent;
    private int consecutiveDays;
    private void Start()
    {
        consecutiveDays = PlayerPrefs.GetInt(DailyRewards.Instance.consecutiveDaysPrefs, 0) + 1;
        textComponent = GetComponent<Text>();
    }

    private void Update()
    {
        

        textComponent.text = "DAYS IN A ROW : " + consecutiveDays;
    }
}

