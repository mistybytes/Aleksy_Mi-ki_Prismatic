using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    private int enemyHealth;

    private bool isFrozen = false;
    private float speed;
    
    private void Start()
    {
        Destroy(gameObject,45);
        speed = GameManager.instance.getSpeed();
        enemyHealth = GameManager.instance.getEnemyHealth();
    }
    
    public float getSpeed()
    {
        return speed;
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
                GameManager.instance.SubLives();
                break;
            default:
                break;
        }
    }
    
    

   
    
    
}
