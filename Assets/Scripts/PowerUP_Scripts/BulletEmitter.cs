using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEmitter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireInterval = 3f;
    private float lastFireTime = 0f;

    void Update()
    {
        if (Time.time - lastFireTime > fireInterval)
        {
            lastFireTime = Time.time;
            FireBullet();
        }
    }

    void FireBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        // Set any necessary properties on the bullet object
    }
}