using System;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public float radius = 5f;           // The radius of the circle
    public float speed = 1f;            // The speed at which the object moves// The height above the ground
    private float angle = 2f;           // The current angle of the object
    
    void Update()
    {
        // Update the angle based on the speed and time
        angle += speed * Time.deltaTime;

        // Calculate the x and y positions using trigonometry
        float x = Mathf.Sin(angle) * radius;
        float y = Mathf.Cos(angle) * radius;

        // Set the position of the object
        transform.position = new Vector3(x, 0, y);
    }
    
    
}