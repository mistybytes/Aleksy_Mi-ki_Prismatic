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

        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (collision.gameObject.GetComponent<enemyManager>().getHealth() - bulletDamage <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
            else
            {
                Destroy(gameObject);
                collision.gameObject.GetComponent<enemyManager>().subHealth(bulletDamage);
            }
        }

    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, circlePosition, speed * Time.deltaTime);
    }
}
