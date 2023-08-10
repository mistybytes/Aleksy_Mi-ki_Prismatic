using System;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    private float radius = 15f;           // The radius of the circle
    private float speed = 0.2f;            // The speed at which the object moves// The height above the ground
    private float angle = 2f;           // The current angle of the object
    
    void Update()
    {
        angle += speed * Time.deltaTime;

        float x = Mathf.Sin(angle) * radius;
        float y = Mathf.Cos(angle) * radius;

        transform.position = new Vector3(x, 0, y);
    }

    public void BossHit()
    {
        speed += 0.1f;
    }
    
}