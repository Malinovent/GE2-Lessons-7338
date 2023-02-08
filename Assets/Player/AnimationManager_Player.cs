using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager_Player : AnimationManager
{


    public void IdleAnimation()
    {
        SetBool("isMoving", false);
        SetInt("idleIndex", Random.Range(0, 3));
    }

    public void MoveAnimation(Vector2 direction)
    {
        if (direction != Vector2.zero)
        {
            SetBool("isMoving", true);
            SetFloat("moveX", direction.x);
            SetFloat("moveZ", direction.y);
        }
        else
        {
            IdleAnimation();
        }
    }

}
