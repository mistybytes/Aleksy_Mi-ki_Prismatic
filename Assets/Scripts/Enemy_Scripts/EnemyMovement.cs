using System;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    public Vector3 target = Vector3.zero;

    private float speed;

    private void Start()
    {
        speed = GameManager.instance.gameSpeed;
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

    void LateUpdate()
    {
        Vector3 direction = target - transform.position;

        float distanceToTarget = Vector3.Distance(transform.position, target);

        if (distanceToTarget > 0)
        {
            direction.Normalize();
            transform.position += direction * speed  *  Time.deltaTime;
        }
    }
    
    

}
