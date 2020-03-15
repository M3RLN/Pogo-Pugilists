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
    public string winner;
    public bool alreadyCounted;
    public Transform playerPos;
    public GameManager gm;
    public StaticItemSelection sis;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        lives = 3;
        inPlay = true;
        gameOver = false;
        alreadyCounted = false;
        winner = "";
        if (player1)
        {
            if (StaticItemSelection.getP1()[0])
            {
                ImmobilizeAbility();
            }
            else if (StaticItemSelection.getP1()[1])
            {
                HitBoxSpawnAbility();
            }
            else if (StaticItemSelection.getP1()[2])
            {
                PulseAbility();
            }
        }
        else
        {
            if (StaticItemSelection.getP2()[0])
            {
                ImmobilizeAbility();
            }
            else if (StaticItemSelection.getP2()[1])
            {
                HitBoxSpawnAbility();
            }
            else if (StaticItemSelection.getP2()[2])
            {
                PulseAbility();
            }
        }
        

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

                Invoke("resetPlayers", 1f);
            }
            else
            {
                gameOver = true;
                if (player1)
                {
                    gm.endGame("Player 1 ");
                }
                else if (player2)
                {
                    gm.endGame("Player 2 ");
                }
            }
        }
    }

    public void resetPlayers()
    {
        transform.position = playerPos.position;
        inPlay = true;
        alreadyCounted = false;
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

    private void ImmobilizeAbility()
    {
        Debug.Log("ImmobilizeAbility gained");
    }

    private void HitBoxSpawnAbility()
    {
        Debug.Log("HitBoxSpawnAbility gained");
    }

    private void PulseAbility()
    {
        Debug.Log("PulseAbility gained");
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
