using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaBlasterProjectile : MonoBehaviour
{
    public float speed = 10f;
    public float damage = 25f;
    public float fireDamagePerSecond = 10f;
    public float fireDuration = 3f;
    public LayerMask impactLayers;
    private int bulletDamage;
    private Rigidbody _rigidbody;
    private Vector3 circlePosition;
    private int delay = 10;
    private PlayerMovement pm;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.velocity = transform.forward * speed;
        
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
    
    private void OnTriggerEnter(Collider collision)
    {
        //TODO make this a switch statement
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
                        StartCoroutine(ApplyFireDamage(collision.gameObject.GetComponent<enemyManager>().getHealth()));
                    }
                }
    }
    
    private IEnumerator ApplyFireDamage(float targetHealth)
    {
        float fireTimer = 0;
        while (fireTimer < fireDuration)
        {
            targetHealth = targetHealth - fireDamagePerSecond * Time.deltaTime;
            fireTimer += Time.deltaTime;
            yield return null;
        }
    }
}