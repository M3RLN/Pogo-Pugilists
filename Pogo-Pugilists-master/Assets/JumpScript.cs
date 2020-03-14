using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public Rigidbody2D rb2;
   
    //public float lockPos;
   

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        //lockPos = 0;
  

        
    }
    //ghuhiu
    // Update is called once per frame
    void Update()
    {
      
        
        if (Input.GetButtonDown("Jump"))
        {
            rb2.AddRelativeForce(Vector2.up * 10, ForceMode2D.Impulse);
            
        }
        
        else
        {
            rb2.freezeRotation = false;
            //gameObject.transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
            gameObject.transform.Rotate(0,0,Input.GetAxis("Horizontal"));
        }
        
    }

   
}
