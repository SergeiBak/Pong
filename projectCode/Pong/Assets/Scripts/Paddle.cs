using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D rb;
    [SerializeField]
    protected float speed = 10f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
