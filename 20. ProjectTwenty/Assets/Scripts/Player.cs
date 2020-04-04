using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int weaponID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponID = 1;
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weaponID = 2;
        }

        switch (weaponID)
        {
            case 1:
                print("Gun");
                break;
            case 2:
                print("Knife");
                break;
        }

    }
}
