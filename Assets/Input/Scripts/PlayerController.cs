using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public void Move(Vector2 dir)
    {
        Debug.Log("Moving in direction: " + dir);
    }

    public void Jump()
    {
        Debug.Log("Jump!");
    }

}
