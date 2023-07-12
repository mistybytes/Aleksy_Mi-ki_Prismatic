using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blaster5Color : MonoBehaviour
{
    private Text _text;
    void Start()
    {
        _text = gameObject.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance._lightBlaster)
        {
            float hue = Mathf.PingPong(Time.time, 1f);
            Color color = Color.HSVToRGB(hue, 0.8f, 1f);
            _text.color = color;
        }
    }
}
