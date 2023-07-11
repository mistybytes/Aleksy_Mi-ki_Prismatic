using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile7 : MonoBehaviour
{
    private int delay = 20;
    private void Start()
    {
        Destroy(gameObject, delay);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (!collision.gameObject.CompareTag("Player"));
        Destroy(collision.gameObject);
    }
}
