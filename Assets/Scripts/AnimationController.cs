using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent <Animator>();
    }

    private void OnMouseDown()
    {
        
    }
}
