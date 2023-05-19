using UnityEngine;

public class RandomStart : MonoBehaviour
{
    public float spawnRange = 10.0f; // The range within which the object can spawn
    public float minDistanceFromOrigin = 2.0f; // The minimum distance from the origin

    // Start is called before the first frame update
    void Start()
    {
        // Generate a random angle
        float angle = Random.Range(0, 2 * Mathf.PI);

        // Generate a random distance from minDistanceFromOrigin to spawnRange
        float distance = Random.Range(minDistanceFromOrigin, spawnRange);

        // Convert polar coordinates to Cartesian coordinates
        float x = distance * Mathf.Cos(angle);
        float z = distance * Mathf.Sin(angle);
        
        Vector3 startPosition = new Vector3(x, 0, z);
        
        // Set the object's position to the starting position
        transform.position = startPosition;
    }
}