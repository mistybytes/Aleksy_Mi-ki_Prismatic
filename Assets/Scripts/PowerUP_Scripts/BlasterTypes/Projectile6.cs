using UnityEngine;

public class Projectile6 : MonoBehaviour
{
    public bool isUnlocked = false;
    
    private int bulletDamage = 5;
    private float delay = 10;

    private int timesUpgraded = 0;
    //TODO MAKE THIS PROJECTILE BE STATIONARY
    private void Start()
    {
        bulletDamage = PlayerPrefs.GetInt("bulletDamage", defaultValue: 10);
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
                collision.gameObject.GetComponent<enemyManager>().subHealth(bulletDamage);
                Destroy(gameObject);
            }
        }
        
    }
}