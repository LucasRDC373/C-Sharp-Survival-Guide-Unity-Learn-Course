using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int playerScore;
    private bool youAreAwesome = false;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerScore += 10;
        }

        if(playerScore >= 50 && youAreAwesome == false)
        {
            youAreAwesome = true;
            print("You are awesome");
        }
    }
}
