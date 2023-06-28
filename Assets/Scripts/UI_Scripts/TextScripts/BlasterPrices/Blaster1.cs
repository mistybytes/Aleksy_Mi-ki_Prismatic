using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blaster1 : MonoBehaviour
{
    
    public ShopController sc;
    private Text _text;
    private int timesUpgraded = 0;
    void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }

    
    void Update()
    {
        _text.text = "UPGRADE : " + sc._classicalBlasterCost.ToString();
    }
}
