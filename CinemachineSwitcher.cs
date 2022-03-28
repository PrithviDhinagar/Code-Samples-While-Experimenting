/*This is part of the sniper scope controller. The below code controls the switching between cinemachine camera's playerFollowCamera and scopeCamera 
 *playerFollowCamera - Cinemachine camera which follows the player.
 *scopeCamera - Zoomed in camera which is enabled using scopeController script and when sniper weapon is equipped. 
 */

using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class CinemachineSwitcher : MonoBehaviour
{
    //Controls the Cinemachine camera switch for zoom in/out effect in Sniper Weapon.
    [SerializeField]
    private InputAction action;
    [SerializeField]
    private CinemachineVirtualCamera vcam1; //playerFollowCamera
    [SerializeField]
    private CinemachineVirtualCamera vcam2; //scopeCamera

    private Animator animator;
    private bool playerFollowCamera = true;

    private void Awake()
    {
        //animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }

    void Start()
    {
        action.performed += _ => SwitchPriority();
    }
    //Switches priority of the Cinemachine camera back and forth from playerFollowCamera to scopeCamera. 
    private void SwitchPriority()
    {
        if(playerFollowCamera)
        {
            vcam1.Priority = 0;
            vcam2.Priority = 1;
        }
        else
        {
            vcam1.Priority = 1;
            vcam2.Priority = 0;
        }
        playerFollowCamera = !playerFollowCamera;
    }
}
