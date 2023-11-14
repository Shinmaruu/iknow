using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryInteract: Interactable
{
    [SerializeField] GameObject gameObject;
    [SerializeField] StoryManager storyManager;
    [SerializeField] private string infoMessage;
    private bool hasInteracted = false;

    void Start()
    {

    }

    void Update()
    {

    }

    protected override void Interact()
    {
        if (hasInteracted == false)
        {
            promptMessage = infoMessage;
            hasInteracted = true;
            storyManager.TriggerFlag();
        }
    }
}
