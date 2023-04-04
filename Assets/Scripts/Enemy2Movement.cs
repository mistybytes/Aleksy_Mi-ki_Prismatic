using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Movement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float spiralSpeed = 2f;
    [SerializeField]// speed of the spiral movement
    private float radius = 10f;
    [SerializeField]// initial radius of the spiral
    private float radiusDecay = 100f;  // rate at which the radius decays

    private float angle = 0f;

    private void Update()
    {
        // Increment the angle based on the speed and time
        angle += Time.deltaTime * spiralSpeed;

        // Reduce the radius based on the decay rate and time
        radius -= radiusDecay * Time.deltaTime;

        // Calculate the new position of the object in a spiral pattern
        float x = radius * Mathf.Cos(angle);
        float z = radius * Mathf.Sin(angle);
        float y = transform.position.y;  // keep the same y position

        // Set the object's position to the new spiral position
        transform.position = new Vector3(x, y, z);
    }
}
