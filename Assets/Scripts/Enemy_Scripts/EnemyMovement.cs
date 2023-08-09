using System;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    private Vector3 target = Vector3.zero;

    public bool freeze;
    private float speed;

    private void Start()
    {
        speed = GameManager.instance.gameSpeed;
    }
    
    void Update()
    {
        if(freeze == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
        
    }



}
