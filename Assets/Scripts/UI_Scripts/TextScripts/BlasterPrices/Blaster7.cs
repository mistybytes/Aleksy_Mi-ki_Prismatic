using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blaster7 : MonoBehaviour
{
    // Start is called before the first frame update
    public ShopController sc;
    private Text _text;
    void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance._voidBlaster)
        {
            _text.text = "UPGRADE : " + GameManager.instance.voidBlasterCost;
        }
        else
        {
            _text.text = "UNLOCK : " + GameManager.instance.voidBlasterCost;
        }
    }
}
