using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayAnimation(string animationName)
    {
        animator.Play(animationName);
    }

    public void SetTrigger(string triggerName)
    {
        animator.SetTrigger(triggerName);
    }

    public void SetBool(string boolName, bool value)
    {
        animator.SetBool(boolName, value);
    }

    public void SetFloat(string floatName, float value)
    {
        animator.SetFloat(floatName, value);
    }

    public void SetInt(string floatName, int value)
    {
        animator.SetInteger(floatName, value);
    }
}
