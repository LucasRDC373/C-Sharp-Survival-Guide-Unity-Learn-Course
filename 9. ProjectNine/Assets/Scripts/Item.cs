using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    // Every item has a name
    // Every item has a description
    // Every item has an image icon
    // Every item has an attack stregth

    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
    public int attackStrength; 

    // Start is called before the first frame update
    void Start()
    {
        print("Name: " + itemName);
        print("Description: " + itemDescription);
        print("Attack: " + attackStrength);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
