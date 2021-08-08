using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour, IAttack
{
    [SerializeField]
    private PlayerAttackCollider attackCollider;
    private PlayerAttackAnimation attackAnimation;
    private bool isAttacking;

    private void OnEnable()
    {
        attackAnimation.playerAttackAnimationEnded += OnAttackAnimationEnded;
    }

    private void OnDisable()
    {
        attackAnimation.playerAttackAnimationEnded -= OnAttackAnimationEnded;
    }

    private void Awake()
    {
        if (attackCollider == null) {
            attackCollider = GetComponentInChildren<PlayerAttackCollider>();
        }

        attackAnimation = GetComponent<PlayerAttackAnimation>();
    }

    private void Update()
    {
        Attack();
    }

    private void OnAttackAnimationEnded()
    {
        attackCollider.DisableCollider();
    }

    public void Attack()
    {
        if (Input.GetButtonDown("Fire1")) {
            attackCollider.EnableCollider();
        }
    }

    public bool IsAttacking()
    {
        return isAttacking;
    }
}
