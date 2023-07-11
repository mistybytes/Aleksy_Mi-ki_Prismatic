using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicBlaster : MonoBehaviour
{
    private int bulletDamage;
    private int delay = 10;
    // Start is called before the first frame update
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
               // Destroy(gameObject);
                Destroy(collision.gameObject);
            }
            else
            {
                collision.gameObject.GetComponent<enemyManager>().subHealth(bulletDamage);
               // Destroy(gameObject);
            }
        }
    }
}
