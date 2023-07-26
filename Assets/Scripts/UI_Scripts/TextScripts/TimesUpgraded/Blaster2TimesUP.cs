using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blaster2TimesUP : MonoBehaviour
{
    private Text _text;
    private int times = 0;
    void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }

    
    void Update()
    {

        if (times < GameManager.instance.plasmaBlasterTimesUp)
        {
            times++;
            _text.text += "III";
            
        }

    }
}