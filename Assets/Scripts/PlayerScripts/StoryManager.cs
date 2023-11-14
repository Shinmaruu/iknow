using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    public int flagsTriggered; 


    // Start is called before the first frame update
    void Start()
    {
        flagsTriggered = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TriggerFlag()
    {
        flagsTriggered++;
    }
}
