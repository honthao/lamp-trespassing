using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb; // Player rigid body

    public float speed = 3; // Player speed

    // Start is called before the first frame update
    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 moveDir = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
        playerRb.transform.position += moveDir * speed * Time.deltaTime;
    }
}

