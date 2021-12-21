using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float speed = 200;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        AddStartingForce();
    }

    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f; // Randomly add x force on ball in either player's or computer's direction
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f); // creates random y angle for ball

        Vector2 direction = new Vector2(x, y);

        rb.AddForce(direction * speed);
    }

    public void AddForce(Vector2 force)
    {
        rb.AddForce(force);
    }
}
