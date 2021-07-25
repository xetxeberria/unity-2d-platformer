using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpAnimation : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;

    private bool jump;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        jump = rb.velocity.y > 0;

        animator.SetBool("jumping", jump);
    }
}
