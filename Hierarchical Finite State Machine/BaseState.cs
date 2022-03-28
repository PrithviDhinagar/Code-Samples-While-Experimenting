//This is base state which controls the entire state machine with Four function Enter, UpdateLogic, UpdatePhysics, Exit. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseState
{
    public string name;
    protected StateMachine stateMachine;

    public BaseState(string name, StateMachine stateMachine)
    {
        this.name = name;
        this.stateMachine = stateMachine;
    }

    public virtual void Enter()
    {

    }
    public virtual void UpdateLogic()
    {

    }
    public virtual void UpdatePhysics()
    {

    }
    public virtual void Exit()
    {

    }
}
