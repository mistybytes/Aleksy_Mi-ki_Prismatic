using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    private float playerSpeed = 3f;
    private bool isClockwise = true;
    private float currentAngle = 2.0f;
    
    private void Start()
    {
        playerSpeed = GameManager.instance.getBlasterType().GetComponent<BlasterVariables>().playerSpeed;
        BulletEmitter emitter = GetComponent<BulletEmitter>();
        
        emitter.bulletPrefab = GameManager.instance.getBlasterType();
        
        StartCoroutine(MyTimer.CountUpTo1Minute());
    }
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
            float angleDelta = Time.deltaTime * playerSpeed * (isClockwise ? -1f : 1f);
            currentAngle += angleDelta;
            Vector3 circlePosition = new Vector3(Mathf.Sin(currentAngle), 0, Mathf.Cos(currentAngle)) * 3;

            transform.position = circlePosition;
        }


    }

    public float getCurrentAngle()
    {
        return currentAngle;
    }
}
