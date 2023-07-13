using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blaster7TimesUP : MonoBehaviour
{
    public ShopController sc;
    private Text _text;
    private int timesUpgraded = 0;
    private int times = 0;
    void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }
    
    void Update()
    {
        if (times < sc.voidBlasterUpgraded)
        {
            times++;
            _text.text += "III";
        }
    }
}