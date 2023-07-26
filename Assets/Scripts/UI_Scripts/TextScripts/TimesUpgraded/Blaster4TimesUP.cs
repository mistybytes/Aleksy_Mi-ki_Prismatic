using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blaster4TimesUP : MonoBehaviour
{
    private Text _text;
    private int times = 0;
    void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }

    
    void Update()
    {

        if (times < GameManager.instance.transformationBlasterTimesUp)
        {
            times++;
            _text.text += "III";
            
        }

    }
}