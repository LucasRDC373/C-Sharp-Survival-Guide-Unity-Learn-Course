using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject cube;
    public Renderer cubeRenderer;
    public int key;

    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.A))
        {
            key = 0;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            key = 1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            key = 2;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            key = 3;
        }

        switch (key)
        {
            case 0:
                cubeRenderer.material.SetColor("_Color", Color.blue);
                break;
            case 1:
                cubeRenderer.material.SetColor("_Color", Color.red);
                break;
            case 2:
                cubeRenderer.material.SetColor("_Color", Color.green);
                break;
            case 3:
                cubeRenderer.material.SetColor("_Color", Color.black);
                break;
            
        }
    }
}
