using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;

public class firstLightRay : MonoBehaviour
{
    // Start is called before the first frame update
    private string SKULL_TAG ="Skull";
    private string PRISM_TAG = "prism";


    private bool isBounced = false;
    private bool exists = true;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        lightRayMovement();
    }

    private void lightRayMovement()
    {
       
        if (!isBounced && exists)
        {
            transform.position += new Vector3(20f, 15f, 0f) * Time.deltaTime;
        }
        else if (isBounced && exists)
        {
            Destroy(gameObject);
            
            isBounced = false;
            exists = false;
        }
    }
   
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(SKULL_TAG))
            {
            isBounced = true;
            }
        if (collision.gameObject.CompareTag(PRISM_TAG)) 
            {
            Destroy(gameObject);
            
           //Destroy(collision.gameObject);
            SceneManager.LoadScene("GAMEOVER");
            
            }
    }
}
