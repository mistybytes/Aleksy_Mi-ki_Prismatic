using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BossManager : MonoBehaviour
{
    private int bossTimesHit = 0;
    private Vector3 position;
    
    public void OnDestroy()
    {
        //TODO make a lot of coins be spawned
        StartCoroutine(LoadSceneAfterDelay());
    }

    public void BossHit()
    {
        switch (bossTimesHit++)
        {
            case 7:
                Destroy(gameObject);
                break;
        }
       
    }
    
    IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("BossDefeated");
    }
 
}