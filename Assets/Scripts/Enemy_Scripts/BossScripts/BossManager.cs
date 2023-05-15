using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    
    [SerializeField]
    private int enemyHealth;
    // Start is called before the first frame update
    private void Start()
    {
        enemyHealth = GameManager.instance.getEnemyHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int getHealth()
    {
        return enemyHealth;
    }
    public void subHealth(int damage)
    {
        enemyHealth -= damage;
    }
 
}