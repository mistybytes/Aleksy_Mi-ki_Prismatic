using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile5 : MonoBehaviour
{
    private int _bulletDamage;

    private void Start()
    {
        _bulletDamage = GameManager.instance.bulletDamage;
        
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        
        var pm = playerObject.GetComponent<PlayerMovement>();
        var currentAngle = pm.getCurrentAngle();
        var circlePosition = new Vector3(Mathf.Sin(currentAngle), 0, Mathf.Cos(currentAngle)) * 5;

        transform.position = circlePosition;
        
        Destroy(gameObject, 20);
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
                case "EnemyBullet":
                    Destroy(gameObject);
                    Destroy(collision.gameObject);
                break;
       
            
        }
      
        
    }

}
