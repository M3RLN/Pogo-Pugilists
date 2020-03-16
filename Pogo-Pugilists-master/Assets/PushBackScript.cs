using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBackScript : MonoBehaviour
{

    public Rigidbody2D Force;
    Rigidbody2D connectedBody;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= .6)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        connectedBody = collision.gameObject.GetComponent<Rigidbody2D>();
        if (Force.transform.parent.tag != collision.gameObject.tag)
        {
            connectedBody.velocity = new Vector2(connectedBody.velocity.x - Force.velocity.x, connectedBody.velocity.y - Force.velocity.y);
        }
        
    }
}
