using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class BulletEmitter : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float fireInterval;
    private float lastFireTime = 0f;

    private void Start()
    {
        if (gameObject.CompareTag("Player"))
            fireInterval = GameManager.instance.getShotSpeed();
        else
        {
            fireInterval = 4f;
        }

        bulletPrefab = GameManager.instance.selectedBlaster;
    }

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
        GameObject bullet = Instantiate(bulletPrefab, transform.position , transform.rotation);
    }
}
