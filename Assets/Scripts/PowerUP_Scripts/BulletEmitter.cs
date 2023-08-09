using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class BulletEmitter : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float fireInterval;
    private float lastFireTime;

    private void Start()
    {
        lastFireTime = Time.time;

        switch (gameObject.tag)
        {
            
            case "Player":
                bulletPrefab = GameManager.instance.selectedBlaster;
                fireInterval = GameManager.instance.shotSpeed;
                break;
            
            case "Enemy2":
                fireInterval = 8f;
                break;
            default:
                
                fireInterval = 8f;
                break;
        }
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
        GameObject g = Instantiate(bulletPrefab, transform.position , transform.rotation);
    }
}
