using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private float speed = 5f;
    
    private PlayerMovement pm;
    private Vector3 circlePosition;
    private float delay = 20f;
    void Start()
    {
        Destroy(gameObject, delay);
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

        if (playerObject != null)
        {
            pm = playerObject.GetComponent<PlayerMovement>();
            float currentAngle = pm.getCurrentAngle();

            circlePosition = new Vector3(Mathf.Sin(currentAngle), 0, Mathf.Cos(currentAngle)) * 40;
        }
    }
   
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, circlePosition, speed * Time.deltaTime);
    }
}
