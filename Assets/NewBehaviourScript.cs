using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeLook Camera : MonoBehaviour
{
    [Header("References")]
    public Transform orientation;
    public Transform player;
    public Transform PlayerObj;
    public Rigidbody rb;
    public float rotationSpeed;

    private void Start();
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        Vector3 viewDir = player.position - new Vector3(transform.position.x, player.position.y, tranform.position.z);
        orientation.foward = viewDir.normalized;
        float horizontalInput = Input.GetAxis("Horisontal");
        float verticalInput = Input.GetAxis("Vertical");
        vector3 inputDir = orientation.forward * verticalInput + orientation.right * horizontalInput;

        if(inputDir != vector3.zero)
            PlayerObj.forward = Vector3.slerp(PlayerObj.forward, inputDir.normalized, Time.deltaTime * rotationSpeed);

    }

}
