using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    private PlayerAttackCollider attackCollider;

    private PlayerAttackAnimation attackAnimation;

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
        if (Input.GetButtonDown("Fire1")) {
            attackCollider.EnableCollider();
        }
    }

    private void OnAttackAnimationEnded()
    {
        attackCollider.DisableCollider();
    }
}
