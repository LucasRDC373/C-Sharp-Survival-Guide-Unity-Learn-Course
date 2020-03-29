using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    public Vector3 startPotition;

    // Start is called before the first frame update
    void Start()
    {
        // component.property = asign new value ;
        transform.position = startPotition; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
