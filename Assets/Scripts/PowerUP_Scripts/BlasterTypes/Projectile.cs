using UnityEngine;

public class Projectile : MonoBehaviour
{
     // Assign your projectile Prefab in the Inspector// The point from which the projectiles will be fired
    public float speed = 1.0f; // Speed of the movement
    public float amplitude = 1.0f; // Amplitude of the movement
    private Rigidbody rb;
    private Renderer weaponRenderer;
    private float time;
    private PlayerMovement pm;
    
    public Vector3 startPosition; 
    // Start is called before the first frame update
    void Start()
    {
        weaponRenderer = GetComponent<Renderer>();
        time = 0.0f;
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
        if (playerObject != null)
        {

            pm = playerObject.GetComponent<PlayerMovement>();
            float currentAngle = pm.getCurrentAngle();

            startPosition = new Vector3(Mathf.Sin(currentAngle), 0, Mathf.Cos(currentAngle)) * 40;

        }
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        // Move the weapon in a wave pattern on the x and z axes, around the starting position
        float x =  amplitude * Mathf.Sin(time * speed);
        float z =  amplitude * Mathf.Sin(time * speed);
        
        transform.position = Vector3.MoveTowards(new Vector3(transform.position.x + x,0,transform.position.z+z), startPosition, speed * Time.deltaTime);
        // Continuously change the weapon's color
        weaponRenderer.material.color = new Color(Mathf.Sin(time), Mathf.Cos(time), Mathf.Sin(time));
        
    }
}