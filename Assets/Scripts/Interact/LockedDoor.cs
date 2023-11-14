using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : Interactable
{
    [SerializeField] GameObject door;
    [SerializeField] StoryManager storyManager;
    [SerializeField] string baseMessage;
    private bool doorOpen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (storyManager.flagsTriggered == 3)
        {
            promptMessage = baseMessage;
        }
    }


    protected override void Interact()
    {
        if (storyManager.flagsTriggered == 3)
        {
            doorOpen = !doorOpen;
            door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
            promptMessage = string.Empty;
        }
        else
        {
            promptMessage = "Hmm... the door is locked, I should search the surroundings";
        }
    }
}
