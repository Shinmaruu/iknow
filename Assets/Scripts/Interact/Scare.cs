using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scare : Interactable
{
    [SerializeField] GameObject scare;
    private bool doorOpen;


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
        scare.GetComponent<Animator>().SetBool("IsOpen", doorOpen);

        StartCoroutine(waiter());
    }
    
    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(3);

        Application.Quit();
    }
}
