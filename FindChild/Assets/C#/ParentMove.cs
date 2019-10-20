using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentMove : MonoBehaviour
{
    private bool isReachTarget;
    private Vector2 targetPosition;

    private const int xMin = -960;
    private const int xMax = 960;
    private const int yMin = -540;
    private const int yMax = 540;
    private bool canMove;

    [SerializeField] private float defaultSpeed = 1f;

    private void Start()
    {
        canMove = true;
        isReachTarget = false;
        DecideTargetPosition();
    }

    private void FixedUpdate()
    {
        if (!canMove)
        {
            return;
        }
        
        DecideTargetPosition();

        this.gameObject.transform.position =
            Vector2.MoveTowards(this.gameObject.transform.position, targetPosition, defaultSpeed);

        if (Vector2.Distance(this.gameObject.transform.position, targetPosition) < 1f)
        {
            isReachTarget = true;
        }
    }

    private void DecideTargetPosition()
    {
        if (!isReachTarget)
        {
            return;
        }
        
        targetPosition = new Vector2(UnityEngine.Random.Range(xMin, xMax), UnityEngine.Random.Range(yMin, yMax));
        isReachTarget = false;
    }
}
