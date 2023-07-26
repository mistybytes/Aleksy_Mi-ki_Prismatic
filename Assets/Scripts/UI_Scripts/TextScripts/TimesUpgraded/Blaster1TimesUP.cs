using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blaster1TimesUP : MonoBehaviour
{
    private Text _text;
    private int times;
    void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }

    
    void Update()
    {

        if (times < GameManager.instance.classicalBlasterTimesUp)
        {
            times++;
            _text.text += "III";
        }

    }
}
