using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnlockedLvlCC : MonoBehaviour
{
    [SerializeField]
    private int number;
    private Text textComponent;

    void Start()
    {
        number = number - 1;
        textComponent = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (number == -1)
        {
            float hue = Mathf.PingPong(Time.time, 1f);
            Color color = Color.HSVToRGB(hue, 0.8f, 1f);
            textComponent.color = color;
        }
        else if (LevelCompletionManager.instance.getLevelCompletionStatus()[number])
        {
            float hue = Mathf.PingPong(Time.time, 1f);
            Color color = Color.HSVToRGB(hue, 0.8f, 1f);
            textComponent.color = color;
        }
        else
        {
            Color color = Color.HSVToRGB(255, 255, 255);
            textComponent.color = color;
        }

    }
}
