using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed = 10f;
    private PlayerMovement pm;
    private Vector3 circlePosition;
    private float delay = 20f;
    private int bulletDamage;
    public float bounceForce = 5.0f;
    private Rigidbody rb;
    void Start()
    {
        //dodac speed pobierany z blaster variables
        bulletDamage = GameManager.instance.getBulletDamage();
        speed = gameObject.GetComponent<BlasterVariables>().playerSpeed;
        Destroy(gameObject, delay);
        // Get the player object and calculate the bullet velocity based on the player's facing direction
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
        if (playerObject != null)
        {

            pm = playerObject.GetComponent<PlayerMovement>();
            float currentAngle = pm.getCurrentAngle();

             circlePosition = new Vector3(Mathf.Sin(currentAngle), 0, Mathf.Cos(currentAngle)) * 40;

        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Vector3 bounceDirection = transform.position - other.gameObject.transform.position;
            bounceDirection.y = 0; // Keep the bounce in the x-z plane

            rb.AddForce(bounceDirection.normalized * bounceForce, ForceMode.Impulse);
        }
    }
    void Update()
    {
 ;
 transform.position = Vector3.MoveTowards(transform.position, circlePosition, speed * Time.deltaTime);
    }
}
