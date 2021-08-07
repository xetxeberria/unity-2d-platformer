using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackAnimation : MonoBehaviour
{
    private Animator animator;

    public delegate void PlayerAttackAnimationEnd();
    public event PlayerAttackAnimationEnd playerAttackAnimationEnded;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            animator.SetTrigger("attack");
        }
    }

    public void AttackAnimationEnded()
    {
        if (playerAttackAnimationEnded != null) {
            playerAttackAnimationEnded();
        }
    }
}
