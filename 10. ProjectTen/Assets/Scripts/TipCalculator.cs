using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{

    // Bill is $40
    // Tip is %20 or based on what the user wants
    // Calculate total amount

    public float bill = 40f;
    public float tip = 20f;
    public float totalMount;
    public float totalTip;

    // Start is called before the first frame update
    void Start()
    {
        totalTip = bill / 100 * tip; 
        totalMount = totalTip + bill;
        print("The bill is: " + bill + ", The tip is: " + totalTip + " And the total amount is: " + totalMount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
