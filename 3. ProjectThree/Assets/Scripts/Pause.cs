using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0; 
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
        }
    }

    
}
