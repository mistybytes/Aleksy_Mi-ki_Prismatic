using System;
using UnityEngine;

public class Projectile : MonoBehaviour
{
     // Assign your projectile Prefab in the Inspector// The point from which the projectiles will be fired
    public float speed = 1.0f; // Speed of the movement
    public float amplitude = 1.0f; // Amplitude of the movement
    private Rigidbody rb;
    private Renderer weaponRenderer;
    private float time;
    private PlayerMovement pm;

    public void Start()
    {
        //Todo make this a turret that moves slowly or in a spirall direction
    }

    public void Update()
    {
        
    }
    
    
}
