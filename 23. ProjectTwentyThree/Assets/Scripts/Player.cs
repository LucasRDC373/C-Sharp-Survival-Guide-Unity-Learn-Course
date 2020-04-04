using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int apples;

    void Start()
    {
        while (apples < 50)
        {
            print("My name is Lucas");
            apples++;
        }
    }

    void Update()
    {

    }
}
