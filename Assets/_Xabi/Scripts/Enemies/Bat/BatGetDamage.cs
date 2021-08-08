using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatGetDamage : MonoBehaviour, IGetDamage
{
    private Collider2D damageCollider;

    private void Awake()
    {
        damageCollider = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetDamage(10);
    }

    public void GetDamage(int damage)
    {
        Destroy(gameObject);
    }
}
