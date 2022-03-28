/* This was part of a project where I worked on hierarchical finite state machine, which controls multiple states. 
 * A set of animations and transitions are assigned when the player moves forward and goes to the walkingForwardState. 
 * Includes Block, Punches, Kicks (Light, Medium and Heavy)
 */

using UnityEngine;
using PlayerControl;
public class PlayerWalkingForwardState : PlayerState
{
    //Controls the walking state when the player is moving forward. 
    private PlayerControlsInput playerControl;
    private PlayerController playerController;

    public PlayerStateId GetId(){
        return PlayerStateId.WalkingForward;
    }

    public void Enter(PlayerSetup player){
        playerControl = player.playerControl;
        playerController = player.playerController;
        Debug.Log("Walking Forward State");
    }

    //Activation of animator which holds the animation
    public void Update(PlayerSetup player){
        if (playerController._isGrounded) {
            if (playerControl.block)
            {
                player.animator.SetTrigger("WalkingForwardBlock");
                Debug.Log("WF_Block");
            }
            if (playerControl.lightPunch) {
                player.animator.SetTrigger("WalkingForwardLightPunch");
                Debug.Log("WF_Light Punch");
            }
            if (playerControl.midPunch) {
                player.animator.SetTrigger("WalkingForwardMidPunch");
                Debug.Log("WF_Mid Punch");
            }
            if (playerControl.heavyPunch) {
                player.animator.SetTrigger("WalkingForwardHeavyPunch");
                Debug.Log("WF_Heavy Punch");
            }
            if (playerControl.lightKick) {
                player.animator.SetTrigger("WalkingForwardLightKick");
                Debug.Log("WF_Light Kick");
            }
            if (playerControl.midKick) {
                player.animator.SetTrigger("WalkingForwardMidKick");
                Debug.Log("WF_Mid Kick");
            }
            if (playerControl.heavyKick) {
                player.animator.SetTrigger("WalkingForwardHeavyKick");
                Debug.Log("WF_Heavy Kick");
            }
        }
    }

    public void Exit(PlayerSetup player){

    }
}
