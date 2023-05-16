using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    
    [SerializeField]
    private int enemyHealth;

    private bool isFrozen = false;
    private float speed;
    
    private void Start()
    {
        Destroy(gameObject);
        speed = GameManager.instance.gameSpeed;
        enemyHealth = GameManager.instance.getEnemyHealth();
    }

    private void Update()
    {
        if(enemyHealth <= 0) Destroy(gameObject);
    }

    public float getSpeed()
    {
        return speed;
    }
    public int getHealth()
    {
        return enemyHealth;
    }
    public void subHealth(int damage)
    {
        enemyHealth -= damage;
        Debug.Log(enemyHealth);
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

    public bool getFreeze()
    {
        return isFrozen;
    }
    
    public void Freeze(float duration)
    {
        StartCoroutine(ApplyFreezeEffect(duration));
    }

    private IEnumerator ApplyFreezeEffect(float duration)
    {
        isFrozen = true;

        yield return new WaitForSeconds(duration);

        isFrozen = false;
    }
    
    
}
