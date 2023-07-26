using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blaster5TimesUP : MonoBehaviour
{
    private Text _text;
    private int times;
    void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }

    
    void Update()
    {

        if (times < GameManager.instance.lightBlasterTimesUp)
        {
            times++;
            _text.text += "III";
            
        }

    }
}