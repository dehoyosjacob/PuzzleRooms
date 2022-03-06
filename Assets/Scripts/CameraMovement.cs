using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float mouseSensitivity = 200f;
    [SerializeField] Transform playerBody;

    float mouseX = 0;
    float mouseY = 0;
    float xRotation = 0f;

    public bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isPaused)
        {
            mouseX = 0f;
            mouseY = 0f;
        }

        else if(!isPaused)
        {
            mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        }

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 50f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
