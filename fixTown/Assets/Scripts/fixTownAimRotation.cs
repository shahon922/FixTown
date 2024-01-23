using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixTownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;
    private fixTownCharacterController _controller;

    // Start is called before the first frame update
    void Awake()
    {
        _controller = GetComponent<fixTownCharacterController>();
    }

    private void Start()
    {
        _controller.OnLookEvent += OnAim;        
    }

    public void OnAim(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }

    
}
