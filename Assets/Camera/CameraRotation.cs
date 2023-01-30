using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraRotation : MonoBehaviour
{

    DefaultInputActions inputActions;
    [SerializeField] private Transform targetTransform;
    [SerializeField] private float degressPerSecond;

    private Vector2 _mouseLook;

    private void Awake()
    {
        inputActions = new DefaultInputActions();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void OnEnable()
    {
        inputActions.Player.Look.performed += UpdateLookAxis;
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Player.Look.performed -= UpdateLookAxis;
        inputActions.Disable();
    }

    private void UpdateLookAxis(InputAction.CallbackContext ctx)
    {
        _mouseLook = ctx.ReadValue<Vector2>();

        Vector2 rotationAxis;
        rotationAxis.y = _mouseLook.x;
        rotationAxis.x = 0;

        //Normalize gives us a direction, using values between -1 and 1
        targetTransform.Rotate(rotationAxis.normalized * degressPerSecond * Time.deltaTime);
    }

}
