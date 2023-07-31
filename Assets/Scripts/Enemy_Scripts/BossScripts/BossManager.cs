using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    private int bossHealth;
    // Start is called before the first frame update
    private void Start()
    {
        bossHealth = 100;
    }
    
 
    public int getHealth()
    {
        return bossHealth;
    }
    public void subHealth(int damage)
    {
        bossHealth -= damage;
    }
 
}