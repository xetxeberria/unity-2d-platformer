using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class BatMovement : EnemyMovement, IMove
{
    [SerializeField]
    private Ease ease;

    [SerializeField]
    private float movementDistance;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float timeBetweenMovements;

    private Vector3 initialPosition;
    private Vector3 finalPosition;

    private float movementDuration;

    private FlipSprite flipSprite;

    private BatFlyAnimation flyAnimation;

    private void Awake()
    {
        flipSprite = GetComponent<FlipSprite>();
        flyAnimation = GetComponent<BatFlyAnimation>();
    }

    private void Start()
    {
        initialPosition = transform.position;
        finalPosition = new Vector3(initialPosition.x + movementDistance, initialPosition.y, initialPosition.z);
        movementDuration = movementDistance / speed;

        Move();
    }

    public void Move()
    {
        StartCoroutine(MovementCycle());
    }


    private IEnumerator MovementCycle()
    {
        while (true) {
            flyAnimation.Fly();
            Tween moveTween = transform.DOMove(finalPosition, movementDuration).SetEase(ease);
            yield return moveTween.WaitForCompletion();

            flyAnimation.StopFlying();
            flipSprite.Flip();
            yield return new WaitForSeconds(timeBetweenMovements);

            flyAnimation.Fly();
            moveTween = transform.DOMove(initialPosition, movementDuration).SetEase(ease);
            yield return moveTween.WaitForCompletion();

            flyAnimation.StopFlying();
            flipSprite.Flip();
            yield return new WaitForSeconds(timeBetweenMovements);
        }
    }
}
