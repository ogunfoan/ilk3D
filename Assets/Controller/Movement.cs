using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Rigidbody capsule;
    public Vector2 moveVal;
    public float moveSpeed=10;

    private void Awake()
    {
        capsule = GetComponent<Rigidbody>();
    }

    public void Moving(InputAction.CallbackContext value)
    {
        moveVal = value.ReadValue<Vector2>();
        capsule.AddForce(new Vector3(moveVal.x*moveSpeed, moveVal.y * moveSpeed), ForceMode.Impulse);
    }
}
