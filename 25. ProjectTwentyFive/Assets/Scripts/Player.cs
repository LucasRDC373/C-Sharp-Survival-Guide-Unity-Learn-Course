using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed;

    void Start()
    {
        maxSpeed = Random.Range(60, 120);
        StartCoroutine(Speed());
    }

    void Update()
    {
        
    }

    IEnumerator Speed()
    {
        WaitForSeconds wait = new WaitForSeconds(5);
        for (int i = 0; i <= maxSpeed; i++)
        {
            print(i);

            yield return wait;
        }
    }
}
