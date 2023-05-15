using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class IceBlaster : MonoBehaviour
{
    public float freezeDuration = 2f;  // freeze duration in seconds
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
                collision.gameObject.GetComponent<enemyManager>().Freeze(freezeDuration);
                collision.gameObject.GetComponent<enemyManager>().subHealth(bulletDamage);
                Destroy(gameObject);
            }
        }
    }

    public void upgradeFreeze()
    {
        freezeDuration += 1f;
    }
    
}