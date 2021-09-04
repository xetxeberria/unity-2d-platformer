using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGetDamage : MonoBehaviour, IGetDamage
{
    private LayerMask enemyLayer;

    void Start()
    {
        enemyLayer = LayerMask.NameToLayer("Enemy");    
    }

    public void GetDamage(int damage)
    {
        Debug.Log($"{gameObject.name}: Damage taken ({damage})");
    }
}
