using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinTextScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Text textComponent;

    private void Start()
    {
        textComponent = GetComponent<Text>();
        textComponent.text = "Coins collected: " + GameManager.instance.getCollectedCoins();

    }

    private void Update()
    {
        float hue = Mathf.PingPong(Time.time, 1f);
        Color color = Color.HSVToRGB(hue, 0.8f, 1f);
        textComponent.color = color;
    }
}
