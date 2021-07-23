using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class BatMovement : EnemyMovement
{
    [SerializeField]
    private Ease ease;

    [SerializeField]
    private float movementDistance;

    [SerializeField]
    private float speed;

    private Vector3 initialPosition;
    private Vector3 finalPosition;

    private float movementDuration;

    private void Start()
    {
        initialPosition = transform.position;
        finalPosition = new Vector3(initialPosition.x + movementDistance, initialPosition.y, initialPosition.z);
        movementDuration = movementDistance / speed;

        StartCoroutine(Move());
    }


    private IEnumerator Move()
    {
        while (true) {
            Tween moveTween = transform.DOMove(finalPosition, movementDuration).SetEase(ease);

            yield return moveTween.WaitForCompletion();

            moveTween = transform.DOMove(initialPosition, movementDuration).SetEase(ease);

            yield return moveTween.WaitForCompletion();
        }
    }
}
