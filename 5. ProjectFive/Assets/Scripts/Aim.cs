﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{

    public Transform _sphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // direction = destination - source
        Vector3 directionToFace = _sphere.position - transform.position;

        //access our current rotation = Quaternion Look Rotation
        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);
        Debug.DrawRay(transform.position, directionToFace, Color.green);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);

    }
}
