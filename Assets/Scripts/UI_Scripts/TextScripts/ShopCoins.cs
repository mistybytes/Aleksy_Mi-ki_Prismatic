using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopCoins : MonoBehaviour
{
    // Start is called before the first frame update
    private Text textComponent;

    private void Start()
    {
        textComponent = GetComponent<Text>();
        
    }


    // Update is called once per frame
    void Update()
    {
        textComponent.text = "$ : " + GameManager.instance.getCoins();
    }
}
