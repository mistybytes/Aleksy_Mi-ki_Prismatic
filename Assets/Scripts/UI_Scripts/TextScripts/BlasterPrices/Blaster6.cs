using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blaster6 : MonoBehaviour
{
    // Start is called before the first frame update
    public ShopController sc;
    private Text _text;
    void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }
    
    void Update()
    {
        if (GameManager.instance._forceBlaster != null)
        {
            _text.text = "UPGRADE : " + sc._forceBlasterCost;
        }
        else
        {
            _text.text = "UNLOCK : " + sc._forceBlasterCost;
        }
    }
}
