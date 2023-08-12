using UnityEngine;

public class Projectile4: MonoBehaviour
{
    public GameObject newObjectPrefab;
    private const float TransformChance = 0.25f;  // 25% chance to transform the enemy
    private int _bulletDamage;

    private void Start()
    {
        _bulletDamage = GameManager.instance.bulletDamage;
        Destroy(gameObject, 10);
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
                    float randomFloat = Random.value;
                
                    if (randomFloat < TransformChance)
                    {
                        Instantiate(newObjectPrefab, collision.transform.position, Quaternion.identity);
                        Destroy(collision.gameObject);
                    }
                    Destroy(gameObject);
                }
                break;
            
            case "Boss":
                collision.gameObject.GetComponent<BossManager>().BossHit();
                collision.gameObject.GetComponent<BossMovement>().BossHit();
                
                Destroy(gameObject);          

                break;
            default:
                break;
        }
    }
    
}