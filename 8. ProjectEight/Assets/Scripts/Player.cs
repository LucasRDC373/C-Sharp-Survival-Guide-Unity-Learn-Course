using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public string myName = "Lucas";
    public int myAge = 18;
    public float speed = 255.5f;
    public int health = 87;
    public int score = 1024;
    public bool keysCollected;
    public int ammoCount = 23;

    // Start is called before the first frame update
    void Start()
    {
        print("Your Name is: " + myName);
        print("Your Age is: " + myAge);
        print("Your speed is: " + speed);
        print("Your health is: " + health);
        print("Your score is: " + score);

        if (keysCollected == true)
        {
            print("You collected the all keys");
        }else if (keysCollected == false)
        {
            print("You did not collected the all keys");
        }

        if(ammoCount > 0)
        {
            print("You have still ammo");
        }else if (ammoCount == 0)
        {
            print("You haven't already ammo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
