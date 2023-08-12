using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Projectile2 : MonoBehaviour
{
    private int _bulletDamage;

    private void Start()
    {
        _bulletDamage = GameManager.instance.bulletDamage;
        Destroy(gameObject, 10);
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
                    
                    var otherRb = collision.gameObject.GetComponent<Rigidbody>();
                    var pushDirection = collision.transform.position - transform.position;
                    pushDirection.y = 0;
                    otherRb.AddForce(pushDirection * 7, ForceMode.Force);
                    
                }
                break;
            
            case "Boss":
                collision.gameObject.GetComponent<BossManager>().BossHit();
                collision.gameObject.GetComponent<BossMovement>().BossHit();
                
                Destroy(gameObject);
                
                break;
            
            default:
                break;
        }
    
    }

}