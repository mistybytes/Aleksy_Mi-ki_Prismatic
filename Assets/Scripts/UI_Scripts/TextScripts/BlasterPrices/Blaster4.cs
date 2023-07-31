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
        if (GameManager.instance.transformationBlaster)
        {
            _text.text = "UPGRADE : " + GameManager.instance.transformationBlasterCost;
        }
        else
        {
            _text.text = "UNLOCK : " + GameManager.instance.transformationBlasterCost;
        }
    }
}
