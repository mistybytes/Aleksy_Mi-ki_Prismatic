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
        textComponent.text = "LIVES : " + GameManager.instance.getLives() + "    $ : " + GameManager.instance.getCollectedCoins();
    }
}
