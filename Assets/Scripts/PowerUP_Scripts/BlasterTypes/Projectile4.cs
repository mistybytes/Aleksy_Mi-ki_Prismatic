using UnityEngine;

public class Projectile4: MonoBehaviour
{
    public GameObject newObjectPrefab;
    private float transformChance = 0.25f;  // 25% chance to transform the enemy
    private int bulletDamage = 10;
    private int delay = 10;
    private void Start()
    {
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
    
    public void upgradeBlaster4()
    {
        
    }
}