using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int myAge = 18∑;
    public int legalAgeToDrive = 16;

    // Start is called before the first frame update
    void Start()
    {
        if (myAge >= legalAgeToDrive)
        {
            print("You are old enough to drive");
        }
        else
        {
            print("You are not old enough to drive");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
