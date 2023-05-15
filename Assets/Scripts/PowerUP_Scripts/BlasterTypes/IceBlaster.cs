using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class IceBlaster : MonoBehaviour
{
    public float freezeDuration = 1f;  // freeze duration in seconds
    private int bulletDamage;
    private int delay = 10;
    private void Start()
    {
        bulletDamage = GameManager.instance.getBulletDamage();

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
                StartCoroutine(Freeze(collision.GetComponent<Rigidbody>()));
                Destroy(gameObject);
            }
        }
    }

    private IEnumerator Freeze(Rigidbody target)
    {
        RigidbodyConstraints originalConstraints = target.constraints;
        
        target.constraints = RigidbodyConstraints.FreezeAll;

        yield return new WaitForSeconds(freezeDuration);
        
        target.constraints = originalConstraints;
    }
}