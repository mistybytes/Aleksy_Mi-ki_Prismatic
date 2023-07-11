using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile2 : MonoBehaviour
{
    public float fireDamagePerSecond = 10f;
    public float fireDuration = 3f;
    private int bulletDamage = 10;
    private int delay = 10;
    private void Start()
    {
        Destroy(gameObject, delay);
    }
    
    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy")) 
        {
                    if (collision.gameObject.GetComponent<enemyManager>().getHealth() - bulletDamage <= 0)
                    {
                        Destroy(gameObject);
                        Destroy(collision.gameObject);
                    }
                    else
                    {
                        Destroy(gameObject);
                        collision.gameObject.GetComponent<enemyManager>().subHealth(bulletDamage);
                        StartCoroutine(ApplyFireDamage(collision.gameObject.GetComponent<enemyManager>().getHealth()));
                    }
        }
    }
    
    private IEnumerator ApplyFireDamage(float targetHealth)
    {
        float fireTimer = 0;
        while (fireTimer < fireDuration)
        {
            targetHealth = targetHealth - fireDamagePerSecond * Time.deltaTime;
            fireTimer += Time.deltaTime;
            yield return null;
        }
    }
}