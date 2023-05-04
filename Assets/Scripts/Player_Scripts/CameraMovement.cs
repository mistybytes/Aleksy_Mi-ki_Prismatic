using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 target = new Vector3(0,0,0);
    private bool isClockwise = true;
    private float currentAngle = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
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
            float angleDelta = Time.deltaTime * 2 * (isClockwise ? -1f : 1f);
            currentAngle += angleDelta;

            Vector3 circlePosition = new Vector3(Mathf.Sin(currentAngle), 2, Mathf.Cos(currentAngle) ) * 10;

            transform.position = circlePosition;
        }


        transform.LookAt(target);
    }
}
