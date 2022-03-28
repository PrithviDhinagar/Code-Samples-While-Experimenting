/*This was part of a project where I worked on hierarchical finite state machine, which controls multiple states. 
 * A set of animations and transitions are assigned when the player moves backward and goes to the walkingBackwardState. 
 * Includes Block, Punches, Kicks (Light, Medium and Heavy)
 */
using UnityEngine;
using PlayerControl;
public class PlayerWalkingBackwardState : PlayerState
{
    //Controls the walking state when the player is moving backwards. 
    private PlayerControlsInput playerControl;
    private PlayerController playerController;

    public PlayerStateId GetId(){
        return PlayerStateId.WalkingBackward;
    }

    public void Enter(PlayerSetup player){
        playerControl = player.playerControl;
        playerController = player.playerController;
        Debug.Log("Walking Backward State");
    }

    //Activation of animator which holds the animation
    public void Update(PlayerSetup player){
        if (playerController._isGrounded) {
            if (playerControl.block)
            {
                player.animator.SetTrigger("WalkingBackwardBlock");
                Debug.Log("WB_Block");
            }
            if (playerControl.lightPunch) {
                player.animator.SetTrigger("WalkingBackwardLightPunch");
                Debug.Log("WB_Light Punch");
            }
            if (playerControl.midPunch) {
                player.animator.SetTrigger("WalkingBackwardMidPunch");
                Debug.Log("WB_Mid Punch");
            }
            if (playerControl.heavyPunch) {
                player.animator.SetTrigger("WalkingBackwardHeavyPunch");
                Debug.Log("WB_Heavy Punch");
            }
            if (playerControl.lightKick) {
                player.animator.SetTrigger("WalkingBackwardLightKick");
                Debug.Log("WB_Light Kick");
            }
            if (playerControl.midKick) {
                player.animator.SetTrigger("WalkingBackwardMidKick");
                Debug.Log("WB_Mid Kick");
            }
            if (playerControl.heavyKick) {
                player.animator.SetTrigger("WalkingBackwardHeavyKick");
                Debug.Log("WB_Heavy Kick");
            }
        }
    }

    public void Exit(PlayerSetup player){

    }
}
