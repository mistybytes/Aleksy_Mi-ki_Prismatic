using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField]
    private Vector3 target;
    [SerializeField]
    private int coinSpeed = 10;
    void Start()
    {
        target = new Vector3(0f, 0f, 0f);
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.instance.coinPickedUp();
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Cube"))
        {
            Destroy(gameObject);
        }
    }

    private void LateUpdate()
    {
        Vector3 direction = target - transform.position;

        float distanceToTarget = Vector3.Distance(transform.position, target);

        if (distanceToTarget > 0)
        {
            direction.Normalize();
            transform.position += coinSpeed * direction *  Time.deltaTime;
        }
    }
}
