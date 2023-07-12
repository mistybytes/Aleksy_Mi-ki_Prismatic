using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blaster5 : MonoBehaviour
{
  
    public ShopController sc;
    private Text _text;
    void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }
    
    void Update()
    {
        if (GameManager.instance._lightBlaster != null )
        {
            _text.text = "UPGRADE : " + sc._lighBlasterCost;
        }
        else
        {
            _text.text = "UNLOCK : " + sc._lighBlasterCost;
        }
    }
}
