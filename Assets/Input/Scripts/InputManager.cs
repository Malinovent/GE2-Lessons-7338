using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    EngineInputControls input;

    [SerializeField] PlayerController player;

    private void Awake()
    {
        input = new EngineInputControls();
    }

    private void OnEnable()
    {
        input.Player.Move.performed += DoMove;
        input.Player.Move.canceled += DoMove;
        input.Player.Jump.performed += DoJump;
        input.Enable();
    }

    private void DoJump(InputAction.CallbackContext obj)
    {
        Debug.Log("Jumped!");
        player.Jump();
    }

    private void StopMove(InputAction.CallbackContext obj)
    {
        Debug.Log("Stopped moving");
    }

    private void DoMove(InputAction.CallbackContext obj)
    {
        player.Move(obj.ReadValue<Vector2>());
        Debug.Log("Performed move in direction " + obj.ReadValue<Vector2>());
    }

    private void OnDisable()
    {
        input.Disable();
    }
}
