using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixTownAnimationController : fixTownAnimations
{
    // Start is called before the first frame update
    void Start()
    {
        _controller.OnMoveEvent += Animation;
    }

    public void Animation(Vector2 direction)
    {
        animator.SetBool("IsWalking", direction.magnitude > 0f);
    }
}
