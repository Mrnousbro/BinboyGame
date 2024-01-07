using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private Animator animator;
    private bool isWalking = false;

    void Start()
    {
        // Get the Animator component attached to the GameObject
        animator = GetComponent<Animator>();

        if (animator == null)
        {
            Debug.LogError("Animator component not found!");
        }
    }

    void Update()
    {
        // Check for gamepad input to trigger walking animation
        // Use the left stick for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Check if there is any movement input
        isWalking = (Mathf.Abs(horizontalInput) > 0.1f || Mathf.Abs(verticalInput) > 0.1f);

        // Update the animator parameters based on the input
        animator.SetBool("IsWalking", isWalking);

        // Rotate the player based on the input (optional)
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }

        // Check for the south button (usually the A button on many gamepads) to trigger jump
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Jump()
    {
        // Implement your jump logic here
        // You can use Rigidbody.AddForce, CharacterController.Move, or other methods based on your setup.
        Debug.Log("Jump!");
    }
}
