using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public float verticalLookLimit = 90f; // Limit for vertical rotation
    private float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Vertical rotation (up and down)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -verticalLookLimit, verticalLookLimit); // Limit vertical rotation

        // Apply rotation
        transform.localRotation = Quaternion.Euler(xRotation, transform.localEulerAngles.y, 0f);
        transform.Rotate(Vector3.up * mouseX, Space.World); // Horizontal rotation
    }
}
