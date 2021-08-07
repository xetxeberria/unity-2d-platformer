using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    private PlayerAttackCollider attackCollider;

    private PlayerAttackAnimation attackAnimation;

    private void Awake()
    {
        if (attackCollider == null) {
            attackCollider = GetComponentInChildren<PlayerAttackCollider>();
        }
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            attackCollider.EnableCollider();
        }
    }
}
