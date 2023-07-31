using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile1 : MonoBehaviour
{
    private int bulletDamage = 5;
    private int delay = 20;
    
    //TODO ADD LOADING THE UPGRADES AND ALSO THE UPGRADES THEMSELVES
    
    void Start()
    {
        Destroy(gameObject, delay);
    }
    private void OnTriggerEnter(Collider collision)
    {
        var t = collision.gameObject.tag;
        switch (t)
        {
            case "Enemy":
                if (collision.gameObject.GetComponent<enemyManager>().getHealth() - bulletDamage <= 0)
                {
                    Destroy(gameObject);
                    Destroy(collision.gameObject);
                }
                else
                {
                    Destroy(gameObject);
                    collision.gameObject.GetComponent<enemyManager>().subHealth(bulletDamage);
                }
                break;
            case "Boss":
                if (collision.gameObject.GetComponent<BossManager>().getHealth() - bulletDamage <= 0)
                {
                    Destroy(gameObject);
                    Destroy(collision.gameObject);
                }
                else
                {
                    collision.gameObject.GetComponent<BossManager>().subHealth(bulletDamage);
                    Destroy(gameObject);
                }
                break;
            default:
                break;
        }
    }

    public void upgradeBlaster1()
    {
        bulletDamage += 10;
        delay -= 1;
    }
    
}
