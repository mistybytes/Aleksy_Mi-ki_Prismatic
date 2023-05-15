using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    
    [SerializeField]
    private int enemyHealth;
    // Start is called before the first frame update
    private void Start()
    {
        enemyHealth = GameManager.instance.getEnemyHealth();
    }
    
    public int getHealth()
    {
        return enemyHealth;
    }
    public void subHealth(int damage)
    {
        enemyHealth -= damage;
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Cube"))
        {
            GameManager.instance.SubLives();
            Destroy(gameObject);
        }
    }
}
