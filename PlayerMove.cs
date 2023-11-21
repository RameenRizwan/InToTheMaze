using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
    Vector2 movement;
   

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed);

    }
}
