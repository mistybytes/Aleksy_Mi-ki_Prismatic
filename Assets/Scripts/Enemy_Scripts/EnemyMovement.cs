using System;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    public Vector3 target = Vector3.zero;

    public bool freeze;
    private float speed;

    private void Start()
    {
        speed = GameManager.instance.gameSpeed;
    }
    
    void LateUpdate()
    {
        if (freeze == false)
        {
            speed = 2f;
            Vector3 direction = target - transform.position;

            float distanceToTarget = Vector3.Distance(transform.position, target);

            if (distanceToTarget > 0)
            {
                direction.Normalize();
                transform.position += direction * speed * Time.deltaTime;
            }
        }
    }



}
