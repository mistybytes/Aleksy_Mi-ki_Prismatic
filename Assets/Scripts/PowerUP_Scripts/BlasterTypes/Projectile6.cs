using UnityEngine;

public class Projectile6 : MonoBehaviour
{
    
    private int _bulletDamage;


    private void Start()
    {
        Destroy(gameObject,20);
        _bulletDamage = GameManager.instance.bulletDamage;
    }
    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy")) 
        {
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
            }
        }
        
    }
}