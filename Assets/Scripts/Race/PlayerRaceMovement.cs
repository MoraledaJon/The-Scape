using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRaceMovement : MonoBehaviour
{
    CharacterController characterController;
    Vector2 currentMovementInput;
    Vector3 currentMovement;
    public float speed = 2.0f;
    public float acceleration = 5.0f;
    public bool canMove = false;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void Move(InputAction.CallbackContext context)
    {
        currentMovementInput = context.ReadValue<Vector2>();
    }

    void HandleMovement()
    {
        currentMovement = new Vector3(currentMovementInput.x, 0, acceleration);

        characterController.Move(currentMovement * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HandleMovement();
    }
}
