using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grinchMove : MonoBehaviour
{
    public GameObject Santa;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Santa.transform.position.x < transform.position.x)
        {
            rb.velocity = new Vector2(-2, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(2, rb.velocity.y);
        }
    }
}
