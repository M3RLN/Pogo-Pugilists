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
        if (gameObject.transform.position.y <= 0)
        {
            gameObject.transform.rotation = Quaternion.identity;
            //gameObject.transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
            rb2.freezeRotation = true;
            rb2.velocity = new Vector2(Input.GetAxis("Horizontal") * 3, rb2.velocity.y);
        }
        else
        {
            rb2.freezeRotation = false;
            //gameObject.transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
            gameObject.transform.Rotate(0,0,Input.GetAxis("Horizontal"));
        }
        
    }

   
}
