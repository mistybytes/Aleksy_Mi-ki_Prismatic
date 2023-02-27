using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LOGO : MonoBehaviour
{
    // Start is called before the first frame update
    private Text txt;


    void Start()
    {
        txt = GetComponent<Text>();
        StartCoroutine(colorChange());
    }


    // Update is called once per frame
    void Update()
    {
       
               
    }

    IEnumerator colorChange()
    {

            while (txt)
            {
                yield return new WaitForSeconds(1 / 2);
                txt.color = new Color(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10));
            }
        
    }
}
