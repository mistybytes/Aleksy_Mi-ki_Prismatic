using System;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    private float speed = 2f;
    private Vector3 target = Vector3.zero;

    void Update()
    {
        MoveTowardsTarget();
    }

    void MoveTowardsTarget()
    {
        Vector3 direction = target - transform.position;

        float distanceToTarget = Vector3.Distance(transform.position, target);

        if (distanceToTarget > 0)
        {
            direction.Normalize();
            //transform.position += direction * speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Cube"))
        {
            Destroy(gameObject);
            GameManager.instance.lives -= 1;
        }
    }
}