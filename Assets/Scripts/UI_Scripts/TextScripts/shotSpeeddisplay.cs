using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class shotSpeeddisplay : MonoBehaviour
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
        if (currentDamage < GameManager.instance.getShotSpeed())
        {
            currentText = updateText();
        }
        textComponent.text = currentText;

    }

    public string updateText()
    {
        string damage = "";
        for (int i = 3; i < GameManager.instance.getShotSpeed(); i+=2 )
        {
            damage += "||";
        }

        return damage;

    }
}
