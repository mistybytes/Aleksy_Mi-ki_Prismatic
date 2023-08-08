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
        var t = collision.gameObject.tag;
        switch (t)
        {
            case "Enemy":
                if (collision.gameObject.GetComponent<enemyManager>().getHealth() - _bulletDamage <= 0)
                {
                    Destroy(gameObject);
                    Destroy(collision.gameObject);
                }
                else
                {
                    Destroy(gameObject);
                    collision.gameObject.GetComponent<enemyManager>().subHealth(_bulletDamage);
                }
                break;
            case "Boss":
                if (collision.gameObject.GetComponent<BossManager>().getHealth() - _bulletDamage <= 0)
                {
                    Destroy(gameObject);
                    Destroy(collision.gameObject);
                }
                else
                {
                    collision.gameObject.GetComponent<BossManager>().subHealth(_bulletDamage);
                    Destroy(gameObject);
                }
                break;
            default:
                break;
        }
    }
    
    
}
