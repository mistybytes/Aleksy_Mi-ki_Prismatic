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
        enemyHealth = enemyHealth - damage;
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Cube"))
        {
            Destroy(gameObject);
            GameManager.instance.SubLives();
        }
    }
    
    

   
    
    
}
