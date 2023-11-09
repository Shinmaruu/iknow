using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    // Start is called before the first frame update
    [SerializeField] private GameObject door;
    private bool doorOpen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //this is where we will design our interaction for the door using code
    protected override void Interact()
    {
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
    }
}
