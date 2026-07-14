using UnityEngine;

public class MobileMovement : MonoBehaviour
{
    [Header("References")]
    public CharacterController controller;
    public Joystick joystick;

    [Header("Movement")]
    public float speed = 4f;
    public float gravity = -9.81f;
    public float jumpHeight = 2f;

    private Vector3 velocity;
    private bool grounded;

    void Update()
    {
        grounded = controller.isGrounded;

        if (grounded && velocity.y < 0)
        {
            velocity.y = -2f;   
        }

        // Ambil input dari joystick
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;

        // Gerakan mengikuti arah player
        Vector3 move = transform.right * horizontal + transform.forward * vertical;

        controller.Move(move * speed * Time.deltaTime);

        // Gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    // Dipanggil oleh tombol Jump
    public void Jump()
    {
        if (grounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }
}