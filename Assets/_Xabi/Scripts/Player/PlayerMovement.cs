using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IMove
{
    private Rigidbody2D rb;

    private float horizontalMovement;

    [SerializeField]
    private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMovement * speed, rb.velocity.y);
    }

    public void Move()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
    }
}
