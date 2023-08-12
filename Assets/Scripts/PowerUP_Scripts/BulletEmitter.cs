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
                
                fireInterval = 5f;
                break;
        }
        
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(bulletPrefab, transform.position , transform.rotation);
            yield return new WaitForSeconds(3);
        }
    }
}
