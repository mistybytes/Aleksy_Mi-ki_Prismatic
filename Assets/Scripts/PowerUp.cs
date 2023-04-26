using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
   
    private  Vector3 target;
    private float speed = 1f;

    void Start()
    {
        target = new Vector3(0f, 0f, 0f);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager playerLife = collision.gameObject.GetComponent<GameManager>();
            playerLife.AddLives();
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Cube"))
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        Vector3 direction = target - transform.position;

        float distanceToTarget = Vector3.Distance(transform.position, target);

        if (distanceToTarget > 0)
        {
            direction.Normalize();
            transform.position += direction * speed * Time.deltaTime;
        }
    }


}
