using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
   

    private float movementX;
    
    private Animator anim;
    private SpriteRenderer sr;
   

    private string moving = "Move";
  
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        playerMoveKeyboard();
        animatePlayer();
    }

    void playerMoveKeyboard()
    {
            movementX = Input.GetAxisRaw("Horizontal");
        
        if (movementX > 0)
        {
            
            gameObject.transform.Rotate( 0f, 0f, 20f * Time.deltaTime * 10f);
            
        }
        else if (movementX < 0)
        {
            
            gameObject.transform.Rotate( 0f, 0f, -20f * Time.deltaTime * 10f);
           
        }
    }
    void animatePlayer()
    {
            if (movementX > 0 )
            {
                anim.SetBool(moving, true);
                sr.flipY = true;
            }
            else if (movementX < 0)
            {
                sr.flipY = false;
                anim.SetBool(moving, true);
            }
            else if (movementX == 0)
            {
               anim.SetBool(moving, false);
            }
     }

    

}//class
