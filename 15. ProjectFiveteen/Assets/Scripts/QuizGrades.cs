using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizGrades : MonoBehaviour
{

    public float quizOne, quizTwo, quizThree, quizFour, quizFive;
    public float average;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        quizOne = Random.Range(0.0f, 100.0f);
        quizTwo = Random.Range(0.0f, 100.0f);
        quizThree = Random.Range(0.0f, 100.0f);
        quizFour = Random.Range(0.0f, 100.0f);
        quizFive = Random.Range(0.0f, 100.0f);

        average = (quizOne + quizTwo + quizThree + quizFour + quizFive) / 5;

        if (average >= 90)
        {
            print("A");
        }
        else if (average >= 80 && average < 90)
        {
            print("B");
        }
        else if (average >= 70 && average < 80)
        {
            print("C");
        }
        else if (average < 70)
        {
            print("F");
        }
    }
}
