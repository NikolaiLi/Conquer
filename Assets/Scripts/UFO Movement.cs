using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    private CharacterController controller;
    private float speed = 5f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float verticalMovement = 0f;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            verticalMovement = -speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            verticalMovement = speed * Time.deltaTime;
        }

        Vector3 movement = transform.TransformDirection(new Vector3(horizontal, verticalMovement, vertical));
        controller.Move(movement);
    }
}