using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    [SerializeField]
    private Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (ball.velocity.x > 0.0f) // Move towards ball y pos
        {
            if (ball.position.y > transform.position.y)
            {
                rb.AddForce(Vector2.up * speed);
            }
            else if (ball.position.y < transform.position.y)
            {
                rb.AddForce(Vector2.down * speed);
            }
        }
        else // Move towards center of map
        {
            if (transform.position.y > 0.0f)
            {
                rb.AddForce(Vector2.down * speed);
            }
            else if (transform.position.y < 0.0f)
            {
                rb.AddForce(Vector2.up * speed);
            }
        }
    }
}
