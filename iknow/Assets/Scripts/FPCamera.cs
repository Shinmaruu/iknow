using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FPCamera : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float sensitivity = 5f;

    float xRotation = 0f;

    bool lockedCursorState = true;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        
        //collect mouse input
        float inputX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float inputY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        //

        xRotation -= inputY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * inputX);

    }
}
