using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixTownCharacterController : MonoBehaviour
{

    //public delegate void OnMoveDel(Vector2 direction);
    //public OnMoveDel OnMoveEvent;

    public event Action<Vector2> OnMoveEvent;
    
    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }
}
