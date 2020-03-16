using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    Rigidbody2D rb2;
    public GameObject HitBox;
    GameObject newHitBox;
   
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
            newHitBox = Instantiate(HitBox, new Vector3(transform.position.x, transform.position.y - 1.5f, 0), transform.rotation);
            newHitBox.GetComponent<PushBackScript>().Force = rb2;
        }
        
        else
        {
            rb2.freezeRotation = false;
            //gameObject.transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
            gameObject.transform.Rotate(0,0,Input.GetAxis("Horizontal"));
        }
        
    }

   
}
