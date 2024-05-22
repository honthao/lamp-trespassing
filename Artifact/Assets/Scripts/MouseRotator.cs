using UnityEngine;

public class MouseRotator : MonoBehaviour
{
    public Transform playerRb;

    public float sensitivity;

    void Start()
    {
        // Hide cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Control how much to rotate horizontally (left/right)
        float yRotation = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        playerRb.Rotate(Vector3.up * yRotation);
    }
}
