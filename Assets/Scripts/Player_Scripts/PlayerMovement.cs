using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    private float playerSpeed = 3f;
    private bool isClockwise = true;
    private float currentAngle = 2.0f;
    private Vector3 circlePosition;
    private void Start()
    {
        playerSpeed = GameManager.instance.getSpeed();
        
        BulletEmitter emitter = GetComponent<BulletEmitter>();
        emitter.bulletPrefab = GameManager.instance.getBlasterType();
        
        StartCoroutine(MyTimer.CountUpTo1Minute());
    }
    void Update()
    {
        
        if (Input.touchCount > 0)
        {
                Touch touch = Input.GetTouch(0);
                
                if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Began )
                {
                    if (touch.position.x < Screen.width / 2)
                    {
                      
                       isClockwise = false;
                       float angleDelta = Time.deltaTime * playerSpeed * (isClockwise ? -1f : 1f);
                       currentAngle += angleDelta; 
                       circlePosition = new Vector3(Mathf.Sin(currentAngle), 0, Mathf.Cos(currentAngle)) * 3;
                       transform.position = circlePosition;
                       
                    }
                    else
                    {
                    
                        isClockwise = true;
                        float angleDelta = Time.deltaTime * playerSpeed * (isClockwise ? -1f : 1f);
                        currentAngle += angleDelta;
                        circlePosition = new Vector3(Mathf.Sin(currentAngle), 0, Mathf.Cos(currentAngle)) * 3;
                        transform.position = circlePosition;
                        
                    }
                }
        }
    }

    public float getCurrentAngle()
    {
        return currentAngle;
    }
}
