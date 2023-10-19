using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FPCamera : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float sensitivity = 5f;
    private float cameraVertRotation = 0;

    bool lockedCursorState = true;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        
        //collect mouse input
        float inputX = Input.GetAxis("Mouse X") * sensitivity;
        float inputY = Input.GetAxis("Mouse Y") * sensitivity;

        //X Axis
        cameraVertRotation -= inputY;
        cameraVertRotation = Mathf.Clamp(cameraVertRotation, -90, 90);
        transform.localEulerAngles = Vector3.right * cameraVertRotation;

        //Y Axis
        player.Rotate(Vector3.up * inputX);

    }
}
