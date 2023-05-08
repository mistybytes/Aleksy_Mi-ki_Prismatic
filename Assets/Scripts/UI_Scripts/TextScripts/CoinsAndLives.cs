using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinsAndLives : MonoBehaviour
{
    // Start is called before the first frame update
    private Text textComponent;

    private void Start()
    {
        textComponent = GetComponent<Text>();
        
    }

    private void Update()
    {
        float hue = Mathf.PingPong(Time.time, 1f);
        Color color = Color.HSVToRGB(hue, 0.8f, 1f);
        textComponent.color = color;
        textComponent.text = "<3 : " + GameManager.instance.getLives() + " $ : " + GameManager.instance.getCollectedCoins();
    }
}
