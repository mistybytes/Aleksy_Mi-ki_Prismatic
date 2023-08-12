using UnityEngine;

public class Projectile6 : MonoBehaviour
{
    
    private int _bulletDamage;


    private void Start()
    {
        var playerObject = GameObject.FindGameObjectWithTag("Player");
        
        var pm = playerObject.GetComponent<PlayerMovement>();
        var currentAngle = pm.getCurrentAngle();
        var circlePosition = new Vector3(Mathf.Sin(currentAngle), 0, Mathf.Cos(currentAngle)) * 5;

        transform.position = circlePosition;

        _bulletDamage = GameManager.instance.bulletDamage;
    }
    private void OnTriggerEnter(Collider collision)
    {
        
        var objectTag = collision.gameObject.tag;

        switch (objectTag)
        {
            case "Enemy":
                if (collision.gameObject.GetComponent<enemyManager>().getHealth() - _bulletDamage <= 0)
                {
                    Destroy(gameObject);
                    Destroy(collision.gameObject);
                    GameManager.instance.EnemyKilled();
                }
                else
                {
                    collision.gameObject.GetComponent<enemyManager>().subHealth(_bulletDamage);
                    Destroy(gameObject);
                }
                break;
            case "EnemyBullet":
                
                Destroy(gameObject);
                Destroy(collision.gameObject);
                
                break;
        }
     
        
    }
}