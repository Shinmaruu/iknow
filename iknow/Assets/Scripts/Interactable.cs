using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //message displayed to player when looking at an interactable
    public string promptMessage;
   
    //this function will be called from our player;
    public void BaseInteract()
    {
        Interact();
    }
    
    protected virtual void Interact()
    {
        // This is for each interactable to do something different, essentially, what the point of the abstract class is
    }
}
