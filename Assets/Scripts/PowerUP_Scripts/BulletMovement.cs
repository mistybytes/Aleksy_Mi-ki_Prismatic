using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed = 10f;
    private PlayerMovement pm;
    private Vector3 circlePosition;
    private float delay = 4f;
    private int bulletDamage;
    
    void Start()
    {
        
        bulletDamage = GameManager.instance.getBulletDamage();

        Destroy(gameObject, delay);
        // Get the player object and calculate the bullet velocity based on the player's facing direction
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

        if (playerObject != null)
        {

            pm = playerObject.GetComponent<PlayerMovement>();
            float currentAngle = pm.getCurrentAngle();

             circlePosition = new Vector3(Mathf.Sin(currentAngle), 0, Mathf.Cos(currentAngle)) * 40;

        }
    }
    void OnTriggerEnter(Collider collision)
    {
        //TODO make this a switch statement
        if (collision.gameObject.CompareTag("Enemy"))
        {

            if (collision.gameObject.GetComponent<EnemyMovement>().getHealth() - bulletDamage <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
            else
            {
                Destroy(gameObject);
                collision.gameObject.GetComponent<EnemyMovement>().subHealth(bulletDamage);
            }
        }

        else if (collision.gameObject.CompareTag("SpiralingEnemy"))
        {
            if (collision.gameObject.GetComponent<SpiralMovement>().getHealth() - bulletDamage <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
            else
            {
                Destroy(gameObject);
                collision.gameObject.GetComponent<SpiralMovement>().subHealth(bulletDamage);
            }
        }
        
        else if (collision.gameObject.CompareTag("Boss"))
        {
            if (collision.gameObject.GetComponent<BossMovement>().getHealth() - bulletDamage <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
            else
            {
                Destroy(gameObject);
                collision.gameObject.GetComponent<BossMovement>().subHealth(bulletDamage);
            }
        }
       
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, circlePosition, speed * Time.deltaTime);
    }
}
