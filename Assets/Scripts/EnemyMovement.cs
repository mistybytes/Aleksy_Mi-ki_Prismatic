using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Vector3 target;

    void Start()
    {
        target = new Vector3(0f, 0f, 0f);
    }
    void OnCollisionEnter(Collision collision)
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

            transform.position += direction * GameManager.instance.gameSpeed * Time.deltaTime;
        }
    }

}
