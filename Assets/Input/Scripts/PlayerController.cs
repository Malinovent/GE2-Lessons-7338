using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;
    private Camera mainCamera;
    private Rigidbody rb;
    private Vector2 moveValue;
    [SerializeField] AnimationManager_Player animator;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main;
    }

    /// <summary>
    /// Move the player relative to the rotation of the camera
    /// </summary>
    private void FixedUpdate()
    {
        Vector3 moveDirection = new Vector3(moveValue.x, 0f, moveValue.y);
        moveDirection = mainCamera.transform.TransformDirection(moveDirection);
        moveDirection.y = 0f;
        rb.MovePosition(rb.position + moveDirection.normalized * moveSpeed * Time.fixedDeltaTime);
    }

    public void Move(Vector2 direction)
    {
        moveValue = direction;

        animator.MoveAnimation(direction);
    }

    public void Jump()
    {
        Debug.Log("Jump!");
    }

    public void Interact()
    {
        Debug.Log("Interacting");
    }

    public void Shoot()
    {
        Debug.Log("Shoot");
    }
}

