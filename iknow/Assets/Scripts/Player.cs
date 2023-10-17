using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float xMove;
    private float yMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        yMove = Input.GetAxisRaw("Vertical") * Time.deltaTime;
        transform.Rotate(0, xMove, 0);
        transform.Rotate(yMove , 0, 0);
    }
}
