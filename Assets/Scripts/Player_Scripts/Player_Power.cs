using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Power : MonoBehaviour
{
    
    bool isFiring = false;

    public void Awake()
    {
        isFiring = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator shootingTime()
    {

        yield return new WaitForSeconds(10);

        isFiring = false;

    }

    public void firing()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if(isFiring)
        {

        }
    }
}
