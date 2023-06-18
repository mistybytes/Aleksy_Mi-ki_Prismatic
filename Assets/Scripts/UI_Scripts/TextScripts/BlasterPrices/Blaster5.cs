using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blaster5 : MonoBehaviour
{
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
        if (GameManager.instance._lightBlaster)
        {
            _text.text = "UPGRADE : " + sc._lighBlasterCost;
        }
        else
        {
            _text.text = "UNLOCK : " + sc._lighBlasterCost;
        }
    }
}
