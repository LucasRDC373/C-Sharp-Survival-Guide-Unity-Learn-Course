using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Public or private reference
    // Data types: string, bool, float, int.
    // Every variable needs a name.


    public string myName = "Lucas";
    public int myAge = 18;

    // Start is called before the first frame update
    void Start()
    {
        print("My name is: " + myName);
        print("My age is: " + myAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
