using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blaster4 : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public ShopController sc;
    private Text _text;
    void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance._transformationBlaster)
        {
            _text.text = "UPGRADE : " + sc._transformationBlasterCost;
        }
        else
        {
            _text.text = "UNLOCK : " + sc._transformationBlasterCost;
        }
    }
}
