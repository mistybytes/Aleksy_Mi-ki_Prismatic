using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile1 : MonoBehaviour
{
    private int _bulletDamage;
    void Start()
    {
        _bulletDamage = GameManager.instance.bulletDamage;
        Destroy(gameObject, 10);
    }
    private void OnTriggerEnter(Collider collision)
    {
        var objectTag = collision.gameObject.tag;
        
        switch (objectTag)
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
                }
                break;
            
                
            case "Boss":
                collision.gameObject.GetComponent<BossManager>().BossHit();
                collision.gameObject.GetComponent<BossMovement>().BossHit();
                
                Destroy(gameObject);
                break;
          
        }
    }
    
    
}
