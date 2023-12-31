using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    [SerializeField] GameObject door;
    private bool doorOpen;

    AudioManager audioManager;

    void Awake()
    {
        //audioManager = gameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    protected override void Interact()
    {
        
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
        //audioManager.PlaySFX(audioManager.doorOpen);
    }
}
