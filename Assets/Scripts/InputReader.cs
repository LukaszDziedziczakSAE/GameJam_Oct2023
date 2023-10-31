using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour, Controls.IPlayerActions
{
    Controls controls;

    public Vector2 Movement;
    public event Action Jump;
    public event Action Attack;
    public bool Sprinting;
    public event Action Exit;


    private void Start()
    {
        controls = new Controls();

        controls.Player.SetCallbacks(this);
        controls.Player.Enable();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Jump?.Invoke();
        }
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        Movement = context.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Attack?.Invoke();
        }
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
        if (context.performed) Sprinting = true;
        else if (context.canceled) Sprinting = false;
    }

    public void OnExit(InputAction.CallbackContext context)
    {
        if (context.performed) Exit?.Invoke();
    }
}
