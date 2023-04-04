using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject[] enemy;

    [SerializeField]
    private Transform leftPos, rightPos, upPos, downPos,DL,DR,UR,UL,S1,S2,S3,S4,S5,S6,S7,S8;

    private GameObject spawnedRay;

    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {

        while (true)
        {
            yield return new WaitForSeconds(1);

            randomSide = Random.Range(0, 15);
            if (randomSide == 8) randomSide = 0;


            if (randomSide == 0)
            {
                spawnedRay = Instantiate(enemy[0]);
                spawnedRay.transform.position = leftPos.position;
            }
            else if (randomSide == 1)
            {
                spawnedRay = Instantiate(enemy[0]);
                spawnedRay.transform.position = rightPos.position;
            }
            else if (randomSide == 2)
            {
                spawnedRay = Instantiate(enemy[0]);
                spawnedRay.transform.position = downPos.position;
            }
            else if (randomSide == 3)
            {
                spawnedRay = Instantiate(enemy[0]);
                spawnedRay.transform.position = upPos.position;
            }
            if (randomSide == 4)
            {
                spawnedRay = Instantiate(enemy[0]);
                spawnedRay.transform.position = UL.position;
            }
            else if (randomSide == 5)
            {
                spawnedRay = Instantiate(enemy[0]);
                spawnedRay.transform.position = UR.position;
            }
            else if (randomSide == 6)
            {
                spawnedRay = Instantiate(enemy[0]);
                spawnedRay.transform.position = DL.position;
            }
            else if (randomSide == 7)
            {
                spawnedRay = Instantiate(enemy[0]);
                spawnedRay.transform.position = DR.position;
            }
            if (randomSide == 8)
            {
                spawnedRay = Instantiate(enemy[0]);
                spawnedRay.transform.position = S1.position;
            }
            else if (randomSide == 9)
            {
                spawnedRay = Instantiate(enemy[0]);
                spawnedRay.transform.position = S2.position;
            }
            else if (randomSide == 10)
            {
                spawnedRay = Instantiate(enemy[0]);
                spawnedRay.transform.position = S3.position;
            }
            else if (randomSide == 11)
            {
                spawnedRay = Instantiate(enemy[0]);
                spawnedRay.transform.position = S4.position;
            }
            if (randomSide == 12)
            {
                spawnedRay = Instantiate(enemy[0]);
                spawnedRay.transform.position = S5.position;
            }
            else if (randomSide == 13)
            {
                spawnedRay = Instantiate(enemy[0]);
                spawnedRay.transform.position = S6.position;
            }
            else if (randomSide == 14)
            {
                spawnedRay = Instantiate(enemy[0]);
                spawnedRay.transform.position = S7.position;
            }
            else if (randomSide == 15)
            {
                spawnedRay = Instantiate(enemy[0]);
                spawnedRay.transform.position = S8.position;
            }

        }//while loop
    }



    // Update is called once per frame
    void Update()
    {

    }
}
