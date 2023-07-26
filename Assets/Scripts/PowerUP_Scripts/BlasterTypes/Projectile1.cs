using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile1 : MonoBehaviour
{
    public int bulletDamage = 10;
    private int delay = 10;
    void Start()
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
                collision.gameObject.GetComponent<enemyManager>().subHealth(bulletDamage);
                Destroy(gameObject);
            }
        }
    }

    public void upgradeBlaster1()
    {
        bulletDamage += 10;
        delay -= 1;
    }
    
}
