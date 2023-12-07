using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovment : MonoBehaviour
{

    CharacterController characterController;
    Vector2 currentMovementInput;
    Vector3 currentMovement;
    public float speed = 2.0f;
    private Animator animation;
    private bool isRunning = false;
    public bool canMove = true;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        animation = GetComponent<Animator>();
    }

    public void Move(InputAction.CallbackContext context)
    {
        currentMovementInput = context.ReadValue<Vector2>();
        if(context.performed)
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }
    }

    public void freeze()
    {
        canMove = false;
    }
    public void unfreeze()
    {
        canMove = true;
    }

    void HandleMovement()
    {
        currentMovement = new Vector3(currentMovementInput.y, 0, -currentMovementInput.x);

        characterController.Move(currentMovement * speed * Time.deltaTime);

        if (currentMovementInput.y != 0 || currentMovementInput.x != 0)
        {

            Vector3 lookDirection = new Vector3(currentMovementInput.x, 0, currentMovementInput.y);
            transform.rotation = Quaternion.LookRotation(lookDirection);
        }
    }

    void HandleAnimation()
    {
        if(isRunning)
        {
            animation.SetBool("isRunning", true);
        }
        else
        {
            animation.SetBool("isRunning", false);
        }
    }

    private void Update()
    {
        if(canMove)
        {
            HandleMovement();
            HandleAnimation();
        }
        
    }
}
