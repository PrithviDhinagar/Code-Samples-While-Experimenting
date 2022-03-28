//This displays the grounded state when the player is in the ground, it changes to jumping state when space is pressed.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : BaseState
{
    protected MovementSM _sm;
 
    
    public Grounded(string name, MovementSM stateMachine) : base(name, stateMachine)
    {
        _sm = (MovementSM)stateMachine;
    }
    public override void UpdateLogic()
    {
        base.UpdateLogic();
        if(Input.GetKeyDown(KeyCode.Space))
        {
            stateMachine.ChangeState(_sm.jumpingState); // changes to jumping state when space is pressed. 
        }
    }
}
