//The player moves to jumping state when space is pressed and when it stops being in contact with the ground layer. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : BaseState
{
    protected MovementSM _sm;
    private bool _grounded;
    private int _groundLayer = 1 << 6;
    
    public Jumping(MovementSM stateMachine) : base("Jumping", stateMachine)
    {
        _sm = (MovementSM)stateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        _sm.spriteRenderer.color = Color.green; //player colour changes to green when on jumping state. 
        Vector2 vel = _sm.rigidbody.velocity;
        vel.y += _sm.jumpForce;
        _sm.rigidbody.velocity = vel;
    }
    public override void UpdateLogic()
    {
        base.UpdateLogic();
        if (_grounded)
        {
            stateMachine.ChangeState(_sm.idleState); //moves to idle state when it comes back to x and y = 0 
        }
    }
    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        _grounded = _sm.rigidbody.velocity.y < Mathf.Epsilon && _sm.rigidbody.IsTouchingLayers(_groundLayer);
    }
}
