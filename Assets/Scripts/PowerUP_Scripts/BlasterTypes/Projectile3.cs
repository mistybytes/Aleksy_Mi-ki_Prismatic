using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile3 : MonoBehaviour
{ 
    private int bulletDamage = 5;
    public int delay = 10;
    private void Start()
    {
        Destroy(gameObject, delay);
    }
    private void OnTriggerEnter(Collider collision)
    {
        tag = collision.gameObject.tag;
        switch (tag)
        {
            case "Enemy":
                if (collision.gameObject.GetComponent<enemyManager>().getHealth() - bulletDamage <= 0)
                {
                    Destroy(gameObject);
                    Destroy(collision.gameObject);
                    GameManager.instance.EnemyKilled();

                }
                else
                {
                    collision.gameObject.GetComponent<enemyManager>().subHealth(bulletDamage);
                    Destroy(gameObject);
                    collision.gameObject.GetComponent<EnemyMovement>().freeze = true;
                }
                break;
            
            case "Enemy2":
                if (collision.gameObject.GetComponent<enemyManager>().getHealth() - bulletDamage <= 0)
                {
                    Destroy(gameObject);
                    Destroy(collision.gameObject);
                }
                else
                {
                    collision.gameObject.GetComponent<enemyManager>().subHealth(bulletDamage);
                    Destroy(gameObject);
                    collision.gameObject.GetComponent<EnemyMovement>().freeze = true;
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
    

}