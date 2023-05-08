using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DamageDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    private Text textComponent;
    private int currentDamage ;
    private string currentText ="|||";
    public void Start()
    {
        textComponent = GetComponent<Text>();
        
    }

    public void Update()
    {
        if (currentDamage < GameManager.instance.getBulletDamage())
        {
            currentText = updateText();
        }
        textComponent.text = currentText;

    }

    public string updateText()
    {
        string damage = "";
       
        for (int i = 10; i < GameManager.instance.getBulletDamage(); i+=5 )
        {
            damage += "||";
            
        }

        return damage ;

    }
}
