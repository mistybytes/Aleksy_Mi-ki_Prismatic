using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlaster : MonoBehaviour
{
    //while selecting this blaster set the emition rate higher and the bullet damage lower
    private int bulletDamage;
    private int delay = 10;
    private void Start()
    {
        bulletDamage = GameManager.instance.getBulletDamage();

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
                
            }
        }
    }
}
