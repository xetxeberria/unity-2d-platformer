using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rb;
    
    [SerializeField]
    private Transform groundChecker;
    [SerializeField]
    private float checkRadius;

    [SerializeField]
    private float jumpForce;
    private bool isGrounded;
    private bool isJumping;

    [SerializeField]
    private float jumpTime;
    private float jumpTimeCounter;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundChecker.position, checkRadius);
        
        if (Input.GetButtonDown("Jump") && isGrounded) {
            isJumping = true;
            jumpTimeCounter = jumpTime;
        }

        if (Input.GetButton("Jump") && isJumping) {
            jumpTimeCounter -= Time.deltaTime;

            if (jumpTimeCounter <= 0) {
                isJumping = false;
            }
        }

        if (Input.GetButtonUp("Jump")) {
            isJumping = false;
        }
    }

    private void FixedUpdate()
    {
        if (!isJumping) return;

        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}
