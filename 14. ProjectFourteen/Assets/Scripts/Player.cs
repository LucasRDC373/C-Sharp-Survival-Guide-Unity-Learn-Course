using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int easyDificulty = 0;
    public int mediumDificulty = 1;
    public int hardDificulty = 2;
    public int currentDificulty;

    // Start is called before the first frame update
    void Start()
    {
        currentDificulty = mediumDificulty;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentDificulty == easyDificulty)
        {
            print("You selected easy");
        }else if(currentDificulty == mediumDificulty)
        {
            print("You selected medium");
        }
        else if (currentDificulty == hardDificulty)
        {
            print("You selected hard");
        }else
        {
            print("Option not avaible");
        }
    }
}
