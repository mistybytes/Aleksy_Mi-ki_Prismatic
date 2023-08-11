using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile2 : MonoBehaviour
{
    public float fireDamagePerSecond = 10f;
    public float fireDuration = 3f;
    private int _bulletDamage = 5;
    private int delay = 10;
    private void Start()
    {
        Destroy(gameObject, delay);
    }
    
    private void OnTriggerEnter(Collider collision)
    {
        tag = collision.gameObject.tag;

        switch (tag)
        {
            case "Enemy":
                if (collision.gameObject.GetComponent<enemyManager>().getHealth() - _bulletDamage <= 0)
                { 
                    Destroy(gameObject);
                    Destroy(collision.gameObject);
                    GameManager.instance.EnemyKilled();

                }
                else 
                { 
                    Destroy(gameObject); 
                    collision.gameObject.GetComponent<enemyManager>().subHealth(_bulletDamage); 
                    StartCoroutine(ApplyFireDamage(collision.gameObject.GetComponent<enemyManager>().getHealth()));
                }
                break;
            case "Boss":
                collision.gameObject.GetComponent<BossManager>().BossHit();
                collision.gameObject.GetComponent<BossMovement>().BossHit();
                
                Destroy(gameObject);
                
                break;

        }
    
    }
    
    private IEnumerator ApplyFireDamage(float targetHealth)
    {
        float fireTimer = 0;
        while (fireTimer < fireDuration)
        {
            targetHealth -= fireDamagePerSecond * Time.deltaTime;
            fireTimer += Time.deltaTime;
            yield return null;
        }
    }
    
}