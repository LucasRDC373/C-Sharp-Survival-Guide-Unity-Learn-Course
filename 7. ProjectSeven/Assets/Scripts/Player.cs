﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int score;
    public float speed = 5.5f;

    public GameObject player;
    public Animator anim;

    public Transform myTransform; 

    // Start is called before the first frame update
    void Start()
    {
        print("My postion is: " + myTransform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
