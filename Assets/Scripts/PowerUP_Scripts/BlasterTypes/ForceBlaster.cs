using UnityEngine;

public class ForceBlaster : MonoBehaviour
{
    public bool isUnlocked = false;
    
    public float speed = 3f;  // speed of the bullet
    public float pushForce = 2f;  // force applied to the enemy
    private int bulletDamage;
    private float delay = 10;
    private void Start()
    {
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
}