using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int points;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            points = 50;
        }else if (Input.GetKeyDown(KeyCode.Q))
        {
            points = 100;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            points = 0;
        }

        switch (points)
        {
            case 50:
                print("Points are 50!");
                break;

            case 100:
                print("Points are 100!");
                break;
            default:
                print("You need 50 or 100 points for receive a message");
                break;
        }
    }
}
