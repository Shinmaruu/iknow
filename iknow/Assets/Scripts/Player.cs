using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] CharacterController characterController;
    [SerializeField] float speed = 5.0f;


    private float gravity = -9.81f;
    private Vector3 playerMove;
     

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMove = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.Move(playerMove * speed * Time.deltaTime);
    }

}
