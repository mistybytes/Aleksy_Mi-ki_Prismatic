using UnityEngine;

public class ForceBlaster : MonoBehaviour
{
    public bool isUnlocked = false;
    
    public float speed;  // speed of the bullet
    public float pushForce;  // force applied to the enemy
    private int bulletDamage;
    private float shotSpeed;
    private float delay = 10;
    private int lives;

    private int timesUpgraded = 0;

    private void Start()
    {
        timesUpgraded = PlayerPrefs.GetInt("timesUpgraded", defaultValue: 0);
        lives = PlayerPrefs.GetInt("lives", defaultValue: 2);
        pushForce = PlayerPrefs.GetFloat("pushForce", defaultValue: 1f);
        speed = PlayerPrefs.GetFloat("speed", defaultValue: 2f);
        shotSpeed = PlayerPrefs.GetFloat("shotSpeed", defaultValue: 3f);
        bulletDamage = PlayerPrefs.GetInt("bulletDamage", defaultValue: 5);

        for (int i = 0; i < timesUpgraded; i++)
        {
            upgradeForceBlaster();
        }

        GameManager.instance.setLives(lives);
        GameManager.instance.setSpeed(speed);
        GameManager.instance.setShotSpeed(shotSpeed);
        
        bulletDamage = gameObject.GetComponent<BlasterVariables>().damage;
        
        Destroy(gameObject, delay);
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
                Rigidbody enemyRigidbody = collision.GetComponent<Rigidbody>();
                Vector3 pushDirection = collision.transform.position - transform.position;
                pushDirection.Normalize();
                enemyRigidbody.AddForce(pushDirection * pushForce);
                collision.gameObject.GetComponent<enemyManager>().subHealth(bulletDamage);
                Destroy(gameObject);
            }
        }
        
    }

    public void upgradeForceBlaster()
    {
        speed++;
        bulletDamage += 10;
        if (timesUpgraded == 2)
        {
            shotSpeed += 0.5f;
            pushForce += 1;
        }
        
    }
}