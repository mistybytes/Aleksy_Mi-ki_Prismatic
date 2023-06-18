using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blaster2 : MonoBehaviour
{
    public ShopController sc;
    private Text _text;
    void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance._plasmaBlaster)
        {
            _text.text = "UPGRADE : " + sc._fireBlasterCost;
        }
        else
        {
            _text.text = "UNLOCK : " + sc._fireBlasterCost;
        }
    }
}
