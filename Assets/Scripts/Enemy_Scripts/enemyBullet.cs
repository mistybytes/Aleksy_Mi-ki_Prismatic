using System;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 targetPosition = Vector3.zero;

    void Update()
    {
        MoveTowardsTarget();
    }

    void MoveTowardsTarget()
    {
        Vector3 directionToTarget = (targetPosition - transform.position).normalized;
        transform.position += directionToTarget * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
       Destroy(gameObject);
    }
}