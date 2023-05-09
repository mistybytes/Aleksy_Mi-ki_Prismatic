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
        
        for (float i = 5 ; i > GameManager.instance.getShotSpeed(); i -= 0.5f )
        {
            damage += "|";
        }

        return damage;

    }
}
