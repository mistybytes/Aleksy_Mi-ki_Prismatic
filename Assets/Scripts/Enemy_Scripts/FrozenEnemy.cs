using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrozenEnemy : MonoBehaviour
{
    // Start is called before the first frame update3
    public int health;
    
    public int getHealth()
    {
        return health;
    }

    public void subHealth(int damage)
    {
        health -= damage;
    }

}
