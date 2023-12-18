using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class santaMove : MonoBehaviour
{
    masterScript ms;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ms = GetComponent<masterScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            rb.velocity = new Vector2(7, rb.velocity.y);
        }
        if (Input.GetKey("left"))
        {
            rb.velocity = new Vector2(-7, rb.velocity.y);
        }
        if(Input.GetKeyDown("up"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 10);
        }
    }
    
}
