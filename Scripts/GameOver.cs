using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{


    private Text txt;

    public bool inMenu = true;

    void Start()
    {
        txt = GetComponent<Text>();
        StartCoroutine(colorChange());
    }
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator colorChange()
    {
        while (true)
        {
            yield return new WaitForSeconds(1 / 2);
            txt.color = new Color(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10));
        }
    }

}
