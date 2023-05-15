using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MMCoinsScript : MonoBehaviour
{
    private Text textComponent;

    private void Start()
    {
        textComponent = GetComponent<Text>();
        textComponent.text = "Coins : " + GameManager.instance.getCoins();
    }
    
}
