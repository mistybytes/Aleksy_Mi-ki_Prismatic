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
            yield return new WaitForSeconds(2);

            randomSide = Random.Range(0, 15);

            switch(randomSide)
            {
                case 0:
                    spawnedRay = Instantiate(enemy[0]);
                    spawnedRay.transform.position = leftPos.position;
                    break;
                case 1:
                    spawnedRay = Instantiate(enemy[0]);
                    spawnedRay.transform.position = rightPos.position;
                    break;
                case 2:
                    spawnedRay = Instantiate(enemy[0]);
                    spawnedRay.transform.position = downPos.position;
                    break;
                case 3:
                    spawnedRay = Instantiate(enemy[0]);
                    spawnedRay.transform.position = upPos.position;
                    break;
                case 4:
                    spawnedRay = Instantiate(enemy[0]);
                    spawnedRay.transform.position = UL.position;
                    break;
                case 5:
                    spawnedRay = Instantiate(enemy[0]);
                    spawnedRay.transform.position = UR.position;
                    break;
                case 6:
                    spawnedRay = Instantiate(enemy[0]);
                    spawnedRay.transform.position = DL.position;
                    break;
                case 7:
                    spawnedRay = Instantiate(enemy[0]);
                    spawnedRay.transform.position = DR.position;
                    break;
                case 8:
                    spawnedRay = Instantiate(enemy[0]);
                    spawnedRay.transform.position = S1.position;
                    break;
                case 9:
                    spawnedRay = Instantiate(enemy[0]);
                    spawnedRay.transform.position = S2.position;
                    break;
                case 10:
                    spawnedRay = Instantiate(enemy[0]);
                    spawnedRay.transform.position = S3.position;
                    break;
                case 11:
                    spawnedRay = Instantiate(enemy[0]);
                    spawnedRay.transform.position = S4.position;
                    break;
                case 12:
                    spawnedRay = Instantiate(enemy[0]);
                    spawnedRay.transform.position = S5.position;
                    break;
                case 13:
                    spawnedRay = Instantiate(enemy[0]);
                    spawnedRay.transform.position = S6.position;
                    break;
                case 14:
                    spawnedRay = Instantiate(enemy[0]);
                    spawnedRay.transform.position = S7.position;
                    break;
                case 15:
                    spawnedRay = Instantiate(enemy[0]);
                    spawnedRay.transform.position = S8.position;
                    break;
            }

        }//while loop
    }



    // Update is called once per frame
    void Update()
    {

    }
}
