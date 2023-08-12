using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CurrentlySelected : MonoBehaviour
{
    private Text _text;
    void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }
    
    void Update()
    {
        switch (GameManager.instance.selectedBlaster.ToString())
            {
                case "BLASTER1 (UnityEngine.GameObject)":
                    _text.text = "SELECTED WEAPON : " + GameManager.instance.blaster1Name;
                    _text.color = Color.magenta;
                    break;
                case "BLASTER2 (UnityEngine.GameObject)":
                    _text.text = "SELECTED WEAPON : " + GameManager.instance.blaster2Name;
                    _text.color = Color.blue;
                    break;
                case "BLASTER3 (UnityEngine.GameObject)":
                    _text.text = "SELECTED WEAPON : " + GameManager.instance.blaster3Name;
                    _text.color = Color.red;
                    break;
                case "BLASTER4 (UnityEngine.GameObject)":
                    _text.text = "SELECTED WEAPON : " + GameManager.instance.blaster4Name;
                    _text.color = Color.yellow;
                    break;
                case "BLASTER5 (UnityEngine.GameObject)":
                    _text.text = "SELECTED WEAPON : " + GameManager.instance.blaster5Name;
                    _text.color = Color.cyan;
                    break;
                case "BLASTER6 (UnityEngine.GameObject)":
                    _text.text = "SELECTED WEAPON : " + GameManager.instance.blaster6Name;
                    _text.color = Color.white;
                    break;
                case "BLASTER7 (UnityEngine.GameObject)":
                    _text.text = "SELECTED WEAPON : " + GameManager.instance.blaster7Name;
                    _text.color = Color.black;
                    break;
                default:
                    break;

            }    }
}
