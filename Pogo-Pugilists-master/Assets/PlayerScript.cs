using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rb2;
    public int lives;
    public bool inPlay;
    public bool gameOver;
    public bool player1;
    public bool player2;
    public bool alreadyCounted;
    public Transform playerPos;
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        lives = 3;
        inPlay = true;
        gameOver = false;
        alreadyCounted = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (player1)
        {
            gm.UpdatePlyer1Lives(lives);
        }
        else if (player2)
        {
            gm.UpdatePlyer2Lives(lives);
        }
        if (!inPlay)
        {
            if (lives > 0)
            {
                transform.position = playerPos.position;
                inPlay = true;
                alreadyCounted = false;
            }
            else
            {
                gameOver = true;
            }
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (!alreadyCounted)
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
            else if (other.CompareTag("Leaves"))
            {
                alreadyCounted = true;
                lives--;
                rb2.velocity = Vector2.zero;
                inPlay = false;
            }
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
