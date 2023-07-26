using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Blaster1TimesUP : MonoBehaviour
{
    // Start is called before the first frame update
    public ShopController sc;
    private Text _text;
    private int times = 0;
    void Start()
    {
        _text = gameObject.GetComponent<Text>();
    }

    
    void Update()
    {

        if (times < sc.classicalBlasterUpgraded)
        {
            times++;
            _text.text += "III";
        }

    }
}
