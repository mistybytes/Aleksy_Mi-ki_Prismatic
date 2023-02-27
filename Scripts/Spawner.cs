using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] light;

    Scene scene;
    [SerializeField]
    private Transform leftPos,rightPos;

    private GameObject spawnedRay;

    public bool game = false; 

    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(SpawnRays());   
    }

    IEnumerator SpawnRays()
    {
        
            while (true)
            {
                yield return new WaitForSeconds(Random.Range(1, 5));
             
                randomIndex = 0;//Random.Range(0, light.Length);
                randomSide = Random.Range(0, 2);

                

                if (randomSide == 0)
                {
                    spawnedRay = Instantiate(light[1]);
                    spawnedRay.transform.position = leftPos.position;
                }
                else
                {
                    spawnedRay = Instantiate(light[0]);
                    spawnedRay.transform.position = rightPos.position;
                }

            }//while loop
     }
        
    

    // Update is called once per frame
    void Update()
    {
       
    }
}//class
