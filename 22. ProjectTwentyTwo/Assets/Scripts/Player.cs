using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0;  i < 100; i++)
        {
            print("i = " + i);

            if (i == 50)
            {
                break;
            }
        }

        print("Loop has finished");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
