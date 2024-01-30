using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform; // Spillerens transform
    public Transform cameraHolderTransform; // Kameraholderens transform (det tomme spilobjekt, som kameraet er et barn af)

    public Vector3 offset; // Offset fra spilleren til kameraet
    public float sensitivity = 2f;
    public float maxLookAngle = 80f;

    private float verticalLookRotation = 0f;

    void LateUpdate()
    {
        // Sørg for at kameraet altid følger spilleren med en vis offset
        cameraHolderTransform.position = playerTransform.position + offset;

        // Drej kameraet for at matche spillerens rotation
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        verticalLookRotation -= mouseY;
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -maxLookAngle, maxLookAngle);

        cameraHolderTransform.rotation = Quaternion.Euler(verticalLookRotation, playerTransform.eulerAngles.y, 0f);
    }
}