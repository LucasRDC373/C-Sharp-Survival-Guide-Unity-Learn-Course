using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{

    public float quizOne, quizTwo, quizThree, quizFour, quizFive;


    // Start is called before the first frame update
    void Start()
    {
        quizOne = Random.Range(0.0f, 10.0f);
        quizTwo = Random.Range(0.0f, 10.0f);
        quizThree = Random.Range(0.0f, 10.0f);
        quizFour = Random.Range(0.0f, 10.0f);
        quizFive = Random.Range(0.0f, 10.0f);

        float average = (quizOne + quizTwo + quizThree + quizFour + quizFive) / 5;
        average = Mathf.Round(average)

        print("The average is: " + average);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
