using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestJump : MonoBehaviour
{
    public Rigidbody2D rb2;
    //public float lockPos;
    public int lives;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        //lockPos = 0;
        lives = 3;

    }

    // Update is called once per frame
    void Update()
    {

       

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            lives--;
            Debug.Log("Hit");
        }

        else if (other.CompareTag("Ground"))
        {
            // Debug.Log("It hit the ground");
        }
    }

    

}
