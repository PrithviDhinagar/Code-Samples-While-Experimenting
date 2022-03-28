//This program was part of internship project, where I was involved in working with gun mechanisms. 
/*EXPLANATION: The code controls the scope in/out effect of a sniper which was part of the project. The scope in effect is based on separate cinemachine 
 * camera (the project involves multiple cinemachine camera's) which was created just to create a zoomed effect when a sniper is equipped and it's priority 
 * changes.
 */
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class ScopeController : MonoBehaviour
{

    [SerializeField]
    private InputAction action;
    [SerializeField]
    
    private Animator animator;
    private bool scopeSelected = false;
    

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

    //A paramter bool was created inside the animator controller in unity and was set to play an animation based on true/false value. 
    private void SwitchPriority()
    {
        if(scopeSelected)
        {
            animator.SetBool("OpenScope", true);
        }
        else
        {
            animator.SetBool("OpenScope", false);
        }
        scopeSelected = !scopeSelected;
    }
}
