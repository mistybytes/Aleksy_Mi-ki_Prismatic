using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 target = new Vector3(0,0,0);
    private bool isClockwise = true;
    private float currentAngle = 2.0f;


    private void Start()
    {
        isClockwise = true;

        float angleDelta = Time.deltaTime * (isClockwise ? -1f : 1f);
        currentAngle += angleDelta;

        Vector3 circlePosition = new Vector3(Mathf.Sin(currentAngle), 2, Mathf.Cos(currentAngle) ) * 10;

        transform.position = circlePosition;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount > 0 )
        {
            Touch touch = Input.GetTouch(0);
            
            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Began)
            {
                if (touch.position.x < Screen.width / 2)
                {
                    isClockwise = true;

                    float angleDelta = Time.deltaTime * (isClockwise ? -1f : 1f);
                    currentAngle += angleDelta;

                    Vector3 circlePosition = new Vector3(Mathf.Sin(currentAngle), 2, Mathf.Cos(currentAngle) ) * 10;

                    transform.position = circlePosition;
                }
                else
                {
                    
                    isClockwise = false;

                    float angleDelta = Time.deltaTime * (isClockwise ? -1f : 1f);
                    currentAngle += angleDelta;

                    Vector3 circlePosition = new Vector3(Mathf.Sin(currentAngle), 2, Mathf.Cos(currentAngle) ) * 10;

                    transform.position = circlePosition;
                }
                transform.LookAt(target);
            }
        }
    }
}
