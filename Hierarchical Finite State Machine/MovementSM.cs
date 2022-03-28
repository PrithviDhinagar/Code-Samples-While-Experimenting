//This program was executed when I was assigned a task in the internship to learn about FInite State Machine. 
/*EXPLANATION: In this program, three different different states idleState, movingState and jumpingState is assigned. */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSM : StateMachine
{
    [HideInInspector]
    public Idle idleState;
    [HideInInspector]
    public Moving movingState;
    [HideInInspector]
    public Jumping jumpingState;
    public Rigidbody2D rigidbody;
    public SpriteRenderer spriteRenderer;
    public float speed = 4f;
    public float jumpForce = 10f;
    private void Awake()
    {
        idleState = new Idle(this);
        movingState = new Moving(this);
        jumpingState = new Jumping(this);
    }

    protected override BaseState GetInitialState()
    {
        return idleState;
    }
}
