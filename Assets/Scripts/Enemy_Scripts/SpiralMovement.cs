using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralMovement : MonoBehaviour
{
    public float speed = 5f;
    public float spiralSpeed = 50f;
    public Vector3 target = Vector3.zero;
    public float minHeight = 0.1f;
    private float currentAngle = 0f;
    
    
    void LateUpdate()
    {
        // Calculate distance to target and normalize it
        Vector3 directionToTarget = (target - transform.position).normalized;

        // Compute the downward spiral movement
        float downwardMovement = Mathf.Max((transform.position.y - minHeight) * Time.deltaTime, 0);
        transform.position = new Vector3(transform.position.x, transform.position.y - downwardMovement, transform.position.z);

        // Compute the spiral movement around the target
        currentAngle += spiralSpeed * Time.deltaTime;
        float radius = Vector3.Distance(new Vector3(transform.position.x, 0, transform.position.z), new Vector3(target.x, 0, target.z));
        float newX = target.x + radius * Mathf.Cos(currentAngle * Mathf.Deg2Rad);
        float newZ = target.z + radius * Mathf.Sin(currentAngle * Mathf.Deg2Rad);
        Vector3 newPosition = new Vector3(newX, transform.position.y, newZ);
        transform.position = Vector3.MoveTowards(transform.position, newPosition, speed * Time.deltaTime);
    }
  
    
    
    
}