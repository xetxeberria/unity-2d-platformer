using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyMovement : MonoBehaviour
{
    private void Awake()
    {
        DOTween.Init(false, true, LogBehaviour.ErrorsOnly);
    }
}
