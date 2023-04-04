using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float radius = 20;
    private float speed = 20;
    private bool isClockwise = true;
    private float currentAngle = 2.0f; 

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            isClockwise = false;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            isClockwise = true;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            float angleDelta = Time.deltaTime * 7 * (isClockwise ? -1f : 1f);
            currentAngle += angleDelta;

            Vector3 circlePosition = new Vector3(Mathf.Sin(currentAngle), 0, Mathf.Cos(currentAngle)) * 5 ;
           
            transform.position = circlePosition;

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentAngle += Mathf.PI; // add 180 degrees to currentAngle
            currentAngle %= Mathf.PI * 2; // wrap currentAngle within 360 degrees
            isClockwise = !isClockwise; // reverse the direction of movement
        }

    }
}
