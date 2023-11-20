using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBehavior : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotationSpeed = 10f;
    private Rigidbody2D rigidbody2D;
    
    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

    }

    
    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rigidbody2D.velocity = Vector2.up * _velocity;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation=Quaternion.Euler(0,0,rigidbody2D.velocity.y*_rotationSpeed);
    }
}
