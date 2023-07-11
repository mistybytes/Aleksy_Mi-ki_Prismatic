using UnityEngine;

public class TransformingBlaster: MonoBehaviour
{
    public GameObject newObjectPrefab;
    public float speed = 10f;
    public float transformChance = 0.25f;  // 25% chance to transform the enemy
    private int bulletDamage;
    private int delay = 10;
    private void Start()
    {
        bulletDamage = GameManager.instance.getBulletDamage();
        
        Destroy(gameObject, delay);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            if (collision.gameObject.GetComponent<enemyManager>().getHealth() - bulletDamage <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
            else
            {
                float randomFloat = Random.value;
                
                if (randomFloat < transformChance)
                {
                    GameObject newObject = Instantiate(newObjectPrefab, collision.transform.position, Quaternion.identity);

                    Destroy(collision.gameObject);
                }
                Destroy(gameObject);
            }
        }
    }
}