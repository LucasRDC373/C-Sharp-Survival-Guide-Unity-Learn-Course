using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // If we use "GetJeyDown" the fuction is executed when key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Space");
        }

        if (Input.GetKey(KeyCode.E))
        {
            print("E");
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            print("F");
        }
    }
}
