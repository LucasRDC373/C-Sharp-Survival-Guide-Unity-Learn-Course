using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1f;
    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(speed > 2f)
        {
            print("Slow Down!");
        }else if(speed < .5f)
        {
            print("Speed up!");
        }

        PlayerMovement();

    }

    public void PlayerMovement()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            speed += .5f;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            speed -= .5f;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput, 0, 0) * speed * Time.deltaTime);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, verticalInput) * speed * Time.deltaTime);
    }

}
