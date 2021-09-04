using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackCollider : MonoBehaviour
{
    private BoxCollider2D boxCollider;

    public int attackPower = 10;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        DisableCollider();
    }

    public void EnableCollider()
    {
        boxCollider.enabled = true;
    }

    public void DisableCollider()
    {
        boxCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IGetDamage getDamageComponent = collision.gameObject.GetComponent<IGetDamage>();

        if (getDamageComponent != null) {
            getDamageComponent.GetDamage(attackPower);
        }
    }
}
