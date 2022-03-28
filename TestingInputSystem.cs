/* This code was implemented when I was learning about the new input system in unity and how execute actions with help of the new input system.
 * The program was learnt from a youtuber named Brackeys (teaches unity and C#).
 * Also learnt how to switch actions maps inside the new input system. 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestingInputSystem : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private PlayerInput playerInput;
    private PlayerInputActions playerInputActions;
    public float jumpForce = 10f;
    public float speed = 3f;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();

        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Jump.performed += Jump;

        playerInputActions.Player.Disable();
        playerInputActions.Player.Jump.PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .OnComplete(callback =>
            {
                Debug.Log(callback.action.bindings[0].overridePath);
                callback.Dispose();
                playerInputActions.Player.Enable();
            })
            .Start();
    }

    //Switches Action map between UI and Player back and forth. 
    private void Update()
    {
        if(Keyboard.current.tKey.wasPressedThisFrame) // when t is pressed 
        {
            playerInput.SwitchCurrentActionMap("UI");
        }
        if (Keyboard.current.yKey.wasPressedThisFrame) // when y is pressed 
        {
            playerInput.SwitchCurrentActionMap("Player");
        }
    }
    private void FixedUpdate()
    {
        Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
        playerRigidbody.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }
    //a upward force is added to the player, to create jump action. 
    public void Jump(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        if (context.performed)
        {
            Debug.Log("Jump!!" + context.phase);
            playerRigidbody.AddForce(Vector3.up * jumpForce , ForceMode.Impulse);
        }
    }

    public void Submit(InputAction.CallbackContext context)
    {
        Debug.Log("Submit" + context);
    }
}
