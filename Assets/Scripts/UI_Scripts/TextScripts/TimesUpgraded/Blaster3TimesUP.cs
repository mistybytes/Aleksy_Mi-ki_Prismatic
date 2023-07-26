using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blaster3TimesUP : MonoBehaviour
{
    private Text _text;
    private int times;
    void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }

    
    void Update()
    {

        if (times < GameManager.instance.iceBlasterTimesUp)
        {
            times++;
            _text.text += "III";
            
        }

    }
}