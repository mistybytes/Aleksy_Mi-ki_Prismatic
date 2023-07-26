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
    //Do upgrades somewhere else
        
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
