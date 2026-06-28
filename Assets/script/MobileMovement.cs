using UnityEngine;

public class MobileMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 4f;
    public float gravity = -9.81f;
    public float jumpHeight = 2f;

    Vector3 velocity;
    bool grounded;

    void Update()
    {
        grounded = controller.isGrounded;

        if (grounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        Vector3 move = Vector3.zero;

        if (GameInput.Forward)
            move += transform.forward;

        if (GameInput.Backward)
            move -= transform.forward;

        if (GameInput.Left)
            move -= transform.right;

        if (GameInput.Right)
            move += transform.right;

        controller.Move(move.normalized * speed * Time.deltaTime);

        if (GameInput.Jump && grounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}