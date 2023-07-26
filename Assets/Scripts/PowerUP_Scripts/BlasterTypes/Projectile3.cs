using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile3 : MonoBehaviour
{
    public float freezeDuration = 0.5f;  // freeze duration in seconds
    private int bulletDamage = 10;
    private int delay = 10;
    private void Start()
    {
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
                collision.gameObject.GetComponent<enemyManager>().subHealth(bulletDamage);
                ApplyFreezeEffect(freezeDuration, collision);
                Destroy(gameObject);
            }
        }
    }
    private IEnumerator ApplyFreezeEffect(float duration, Collider g)
    {
        g.gameObject.GetComponent<EnemyMovement>().freeze = true;

        yield return new WaitForSeconds(duration);

        g.gameObject.GetComponent<EnemyMovement>().freeze = false;
    }
    public void setVariables()
    {
        //TODO add this to every blaster and call upon selecting it to set the variables of the player and stuff
    }
    public void upgradeBlaster3()
    {
        freezeDuration += 0.5f;
    }
    
}