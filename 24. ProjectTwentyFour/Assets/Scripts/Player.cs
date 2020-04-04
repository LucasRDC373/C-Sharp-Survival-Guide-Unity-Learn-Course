using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Start()
    {
       
        for(int i = 0; i <= 30; i++)
        {
            do
            {
                print(i);
                i++;
            } while (i < 10);

            if (i <= 20 && i % 2 == 0)
            {
                print(i);
                i++;
            }
            else if(i > 20 && i <= 30 && i %2 > 0)
            {
                print(i);
                i++;
            }
        }

        print("Loop has finished");

    }

    void Update()
    {
        
    }
}
