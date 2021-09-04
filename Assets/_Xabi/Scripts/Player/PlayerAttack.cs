using UnityEngine;

public class PlayerAttack : MonoBehaviour, IAttack
{
    [SerializeField]
    private PlayerAttackCollider attackCollider;
    private PlayerAttackAnimation attackAnimation;
    public bool isAttacking;

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
        isAttacking = false;
    }

    public void Attack()
    {
        if (Input.GetButtonDown("Fire1")) {
            attackCollider.EnableCollider();
            isAttacking = true;
        }
    }

    public bool IsAttacking()
    {
        return isAttacking;
    }
}
