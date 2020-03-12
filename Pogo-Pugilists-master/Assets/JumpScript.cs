using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public Rigidbody2D rb2;
    public Transform playerPos;
    //public float lockPos;
    public int lives;
    public bool inPlay;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        //lockPos = 0;
        lives = 3;
        inPlay = true;
        gameOver = false;

        
    }
    //ghuhiu
    // Update is called once per frame
    void Update()
    {
        if (!inPlay)
        {
            if(lives >= 0)
            {
                transform.position = playerPos.position;
                inPlay = true;
            }
            else
            {
                gameOver = true;
            }
        }
        
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //lives--;
            Debug.Log("Hit");
        }

        else if (other.CompareTag("Ground"))
        {
           // Debug.Log("It hit the ground");
        }

        else if(other.CompareTag("Leaves"))
        {
            lives--;
            rb2.velocity = Vector2.zero;
            inPlay = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // If you want to add a health pool instead of stocks
        //if (other.transform.CompareTag("Player"))
        //{
        //    if (other.gameObject.GetComponent<TestJump>().lives <= 0)
        //    {
        //
        //        Destroy(other.gameObject);
        //    }
        //}

    }
}
