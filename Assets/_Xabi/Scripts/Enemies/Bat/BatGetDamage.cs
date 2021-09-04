using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatGetDamage : MonoBehaviour, IGetDamage
{
    private LayerMask playerAttackLayer;

    private void Start()
    {
        playerAttackLayer = LayerMask.NameToLayer("PlayerAttack");
    }

    public void GetDamage(int damage)
    {
        Debug.Log($"{gameObject.name}: Damage taken ({damage})");
    }
}
