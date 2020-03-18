using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    Rigidbody2D rb2;
    public GameObject HitBox;
    GameObject newHitBox;
    public string moveAxis;
    public string jumpButton;

    //public float lockPos;


    // Start is called before the first frame update
    void Awake()
    {
        rb2 = GetComponent<Rigidbody2D>();
        //lockPos = 0;



    }
    //ghuhiu
    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown(jumpButton))
        {
            rb2.AddRelativeForce(Vector2.up * 10, ForceMode2D.Impulse);
            //newHitBox = Instantiate(HitBox, new Vector3(transform.position.x, transform.position.y - 1.5f, 0), transform.rotation);
            newHitBox = Instantiate(HitBox, gameObject.transform.position + Vector3.down, transform.rotation);
            newHitBox.GetComponent<PushBackScript>().Force = rb2;
        }

        else
        {
            //rb2.freezeRotation = false;
            //gameObject.transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
            gameObject.transform.Rotate(0,0,Input.GetAxis(moveAxis) * 1.2f);
        }

    }


}
