using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    private int enemyHealth;

    private float speed;

    public void OnDestroy()
    {
        
        Debug.Log("i am destroyed");
    }

    private void Start()
    {
        Destroy(gameObject,25);
        
        speed = GameManager.instance.gameSpeed;
        enemyHealth = GameManager.instance.enemyHealth;
        
    }
    
    public int getHealth()
    {
        return enemyHealth;
    }
    public void subHealth(int damage)
    {
        enemyHealth -= damage;
    }
    void OnTriggerEnter(Collider collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                Destroy(gameObject);
                break;
            case "Cube":
                Destroy(gameObject);
                GameManager.instance.lives -= 1;
                break;
            default:
                break;
        }
    }
    
    

   
    
    
}
