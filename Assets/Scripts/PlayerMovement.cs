using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float sensitivity;
    private float horizontalInput;
    private float verticalInput;
    private float rotationX;
    private float rotationY;
    private float mouseX;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        rotationY = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensitivity;
        rotationX = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitivity;
        mouseX += rotationX;
        transform.Rotate(Vector3.up * rotationY);
        Camera.main.transform.Rotate(new Vector3(-rotationX, 0, 0));
    }

    private void FixedUpdate()
    {
        transform.Translate(horizontalInput * speed, 0, verticalInput * speed);
    }
}
