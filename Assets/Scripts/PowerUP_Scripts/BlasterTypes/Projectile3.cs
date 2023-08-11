using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile3 : MonoBehaviour
{ 
    private int _bulletDamage;
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
                if (collision.gameObject.GetComponent<enemyManager>().getHealth() - _bulletDamage <= 0)
                {
                    Destroy(gameObject);
                    Destroy(collision.gameObject);
                    GameManager.instance.EnemyKilled();

                }
                else
                {
                    collision.gameObject.GetComponent<enemyManager>().subHealth(_bulletDamage);
                    Destroy(gameObject);
                    //TODO make this instanciate an enemy that simply is not moving
                }
                break;

            case "Boss":
                collision.gameObject.GetComponent<BossManager>().BossHit();
                collision.gameObject.GetComponent<BossMovement>().BossHit();
                
                Destroy(gameObject);          
            
                break;
        }
   
    } 
    

}