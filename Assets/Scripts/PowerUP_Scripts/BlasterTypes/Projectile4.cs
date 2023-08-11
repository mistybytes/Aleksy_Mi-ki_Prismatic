using UnityEngine;

public class Projectile4: MonoBehaviour
{
    public GameObject newObjectPrefab;
    private float transformChance = 0.25f;  // 25% chance to transform the enemy
    private int bulletDamage = 5;
    private int delay = 10;
    private void Start()
    {
        Destroy(gameObject, delay);
    }

    private void OnTriggerEnter(Collider collision)
    {
        var objectTag = collision.gameObject.tag;
        
        //TODO add a switch case here
        switch (objectTag)
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
                    float randomFloat = Random.value;
                
                    if (randomFloat < transformChance)
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
        }
        if (collision.CompareTag("Enemy"))
        {
          
        }
    }
    
}