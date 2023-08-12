using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile5 : MonoBehaviour
{
    private int _bulletDamage;

    private void Start()
    {
        _bulletDamage = GameManager.instance.bulletDamage;
        Destroy(gameObject, 10);
    }

    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy") ) 
        {
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
        }  
        
    }

}
