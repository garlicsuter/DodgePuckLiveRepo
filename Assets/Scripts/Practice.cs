using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    int score = 5;
    string petNameDog = "Sam";
    bool lights = false;
    float power = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        score += 3;

        if(score > 6)
        {
            //runs this code if the condition is true
            print(score + "my dog is " + petNameDog + " power: " + power);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Pseudocode:
        //Every frame, check if the F key was pressed.
        //If so, add 2 to the score.
        if (Input.GetKeyDown(KeyCode.F))
        {
            print("You pressed F");
            score += 10;
            print("Score = " + score);
        }
     
    }
}
