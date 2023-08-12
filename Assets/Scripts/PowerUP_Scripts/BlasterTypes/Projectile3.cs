using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile3 : MonoBehaviour
{ 
    private int _bulletDamage;
    public GameObject frozenEnemy;

    private void Start()
    {
        _bulletDamage = GameManager.instance.bulletDamage;
        Destroy(gameObject, 10);
    }
    private void OnTriggerEnter(Collider collision)
    {
        tag = collision.gameObject.tag;
        
        switch (tag)
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
                    Destroy(collision.gameObject);
                    
                    Instantiate(frozenEnemy, collision.transform.position, Quaternion.identity);
                }
                break;
            
            case "FrozenEnemy":
                Destroy(gameObject);
                Destroy(collision.gameObject);
                GameManager.instance.EnemyKilled();
                break;
            
            case "Boss":
                collision.gameObject.GetComponent<BossManager>().BossHit();
                collision.gameObject.GetComponent<BossMovement>().BossHit();
                
                Destroy(gameObject);          
            
                break;
        }
   
    } 
    

}