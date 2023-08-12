using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private float speed = 6f;
    
    private PlayerMovement pm;
    private Vector3 circlePosition;

    void Start()
    { 
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

        if (playerObject != null)
        {
            pm = playerObject.GetComponent<PlayerMovement>();
            var currentAngle = pm.getCurrentAngle();

            circlePosition = new Vector3(Mathf.Sin(currentAngle), 0, Mathf.Cos(currentAngle)) * 40;
        }
    }
   
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, circlePosition, speed * Time.deltaTime);
    }
}
