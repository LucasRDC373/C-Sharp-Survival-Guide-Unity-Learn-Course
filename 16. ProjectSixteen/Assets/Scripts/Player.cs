using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject cube;
    public int scoreValue;
    public bool cubeGreen = false;
    public Renderer cubeRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //Get the Renderer component from the new cube
        cubeRenderer = cube.GetComponent<Renderer>();
        //Call SetColor using the shader property name "_Color" and setting the color to red
        cubeRenderer.material.SetColor("_Color", Color.red);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scoreValue += 10;
        }

        if(scoreValue >= 50 && cubeGreen == false)
        {
            cubeRenderer.material.SetColor("_Color", Color.green);
        }
    }
}
