using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blaster7Color : MonoBehaviour
{
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
            float hue = Mathf.PingPong(Time.time, 1f);
            Color color = Color.HSVToRGB(hue, 0.8f, 1f);
            _text.color = color;
        }
    }
}
