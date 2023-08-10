using Unity.VisualScripting;
using UnityEngine;

public class EnemyZigZag : MonoBehaviour
{
    public float speed = 5f; // The speed of the enemy
    public float zigzagWidth = 5f; // The width of the zig-zag pattern
    public float changeDirectionTime = 2f; // The time it takes to change direction

    private Vector3 target = Vector3.zero;
    private Vector3 initialPosition;
    private Vector3 targetPosition;
    private float timeElapsed = 0f;
    private bool movingRight = true;
    public bool freeze = false
        ;
    void Start()
    {
        initialPosition = transform.position;
        SetNextTargetPosition();
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= changeDirectionTime)
        {
            SetNextTargetPosition();
            timeElapsed = 0f;
        }
        if(freeze == false)
        {
            Vector3 direction = target - transform.position;

            float distanceToTarget = Vector3.Distance(transform.position, target);

            if (distanceToTarget > 0)
            {
                direction.Normalize();
                transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            }
        }   
    }

    void SetNextTargetPosition()
    {
        
        //TODO make this much better, he can move in a zig zag
        //TODO increase enemy spawn rate also
        
        if (movingRight)
        {
            targetPosition = initialPosition + new Vector3(zigzagWidth, 0f, zigzagWidth);
        }
        else
        {
            targetPosition = initialPosition - new Vector3(zigzagWidth, 0f, zigzagWidth);
        }

       
        
            Vector3 direction = target - transform.position;

            float distanceToTarget = Vector3.Distance(transform.position, target);

            if (distanceToTarget > 0)
            {
                direction.Normalize();
                transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            }
        
    }
}