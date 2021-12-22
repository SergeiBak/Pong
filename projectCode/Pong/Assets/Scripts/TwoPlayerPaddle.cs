using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPlayerPaddle : Paddle
{
    [SerializeField]
    private KeyCode upInput;
    [SerializeField]
    private KeyCode downInput;

    private Vector2 direction;

    private void Update()
    {
        if (Input.GetKey(upInput))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(downInput))
        {
            direction = Vector2.down;
        }
        else
        {
            direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0)
        {
            rb.AddForce(direction * speed);
        }
    }
}
