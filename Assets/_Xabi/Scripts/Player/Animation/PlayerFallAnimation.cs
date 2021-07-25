using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallAnimation : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;

    private bool fall;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        fall = rb.velocity.y < 0;

        animator.SetBool("falling", fall);
    }
}
