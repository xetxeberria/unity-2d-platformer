using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatFlyAnimation : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Fly()
    {
        animator.SetBool("flying", true);
    }

    public void StopFlying()
    {
        animator.SetBool("flying", false);
    }
}
