using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossManager : MonoBehaviour
{
    private int bossTimesHit = 0;
    private Vector3 position;
    public GameObject coinSpawner;
    public void BossHit()
    {
        bossTimesHit++;
        if (bossTimesHit == 7)
        { 
            Destroy(gameObject);
            
        }
    }
    
 
}