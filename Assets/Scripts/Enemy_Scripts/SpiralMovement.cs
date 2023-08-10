using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralMovement : MonoBehaviour
{
    private float speed = 5f;
    private float spiralSpeed = 50f;
    private Vector3 target = Vector3.zero;
    private float minHeight = 0f;
    private float currentAngle;
    
    private bool freeze = false;
    
    
    void LateUpdate()
    {
        Vector3 directionToTarget = (target - transform.position).normalized;

            float downwardMovement = Mathf.Max((transform.position.y - minHeight) * Time.deltaTime, 0);
            transform.position = new Vector3(transform.position.x, transform.position.y - downwardMovement,
                transform.position.z);

            currentAngle += spiralSpeed * Time.deltaTime;
            
            float radius = Vector3.Distance(new Vector3(transform.position.x, 0, transform.position.z),
                new Vector3(target.x, 0, target.z));
            float newX = target.x + radius * Mathf.Cos(currentAngle * Mathf.Deg2Rad);
            float newZ = target.z + radius * Mathf.Sin(currentAngle * Mathf.Deg2Rad);
            Vector3 newPosition = new Vector3(newX, transform.position.y, newZ);
            
            transform.position = Vector3.MoveTowards(transform.position, newPosition, speed * Time.deltaTime);
        
    }
  
    
    
    
}