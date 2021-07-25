using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkAnimation : MonoBehaviour
{
    private Animator animator;
    private PlayerJump playerJump;

    private bool walk;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        playerJump = GetComponent<PlayerJump>();
    }

    private void Update()
    {
        walk = Input.GetAxis("Horizontal") != 0 && !playerJump.IsJumping();

        animator.SetBool("walking", walk);
    }
}
