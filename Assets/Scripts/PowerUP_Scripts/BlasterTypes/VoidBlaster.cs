using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidBlaster : MonoBehaviour
{
    private int delay = 10;
    private void Start()
    {
        Destroy(gameObject, delay);
    }
    private void OnTriggerEnter(Collider collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
