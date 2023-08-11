using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile1 : MonoBehaviour
{
    private int _bulletDamage;
    private int delay = 20;
    
    //TODO ADD LOADING THE UPGRADES AND ALSO THE UPGRADES THEMSELVES
    
    void Start()
    {
        _bulletDamage = GameManager.instance.bulletDamage;
        Destroy(gameObject, delay);
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
