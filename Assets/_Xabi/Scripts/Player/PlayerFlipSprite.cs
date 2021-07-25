using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    Left,
    Right
}

public class PlayerFlipSprite : FlipSprite
{
    private Direction lastDirection;
    private Direction currentDirection;

    private float horizontalMovement;

    private void Start()
    {
        lastDirection = Direction.Right;
    }

    private void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        if (horizontalMovement == 0) return;

        if (horizontalMovement > 0) {
            currentDirection = Direction.Right;
        } else if (horizontalMovement < 0) {
            currentDirection = Direction.Left;
        }

        if (currentDirection != lastDirection) Flip();

        lastDirection = currentDirection;
    }
}
