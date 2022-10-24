using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float movingSpeed;
    public float horizontalInput;
    public float verticalInput;
    public float jumpForce;

    private Rigidbody playerRigi;
    private bool isOnGround;

    // Start is called before the first frame update
    void Start()
    {
        playerRigi = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(horizontalInput * movingSpeed * Time.deltaTime, 0, verticalInput * movingSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround) {
            Jump();
        }

    }

    void Jump() {
        playerRigi.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isOnGround = false;
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            isOnGround = true;
        }
    }

    private void OnCollisionStay(Collision collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            isOnGround = true;
        }
    }

    private void OnCollisionExit(Collision collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            isOnGround = false;
        }
    }
}
