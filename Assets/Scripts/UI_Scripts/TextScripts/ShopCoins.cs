using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopCoins : MonoBehaviour
{
    private Text textComponent;

    private void Start()
    {
        textComponent = GetComponent<Text>();
    }


    void Update()
    {
        textComponent.text = "$ : " + GameManager.instance.getCoins();
    }
}
