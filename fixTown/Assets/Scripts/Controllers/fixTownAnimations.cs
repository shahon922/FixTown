using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixTownAnimations : MonoBehaviour
{
    protected Animator animator;
    protected fixTownCharacterController _controller;


    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        _controller = GetComponent<fixTownCharacterController>();
    }
}
