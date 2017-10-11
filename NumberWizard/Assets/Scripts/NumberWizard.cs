using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int min = 1;
    int max = 1000;
    int guess = 500;
    
    void NextGuess()
    {
        print("Is the number greater or smaller than " + guess + " ?");
        print("UP: Greater DOWN: Smaller ENTER: Equal");
    }

    void StartGame()
    {
        Debug.Log("Please choose a number in your head between " + min + " and " + max);
        print("Is the number greater or smaller than " + guess + " ?");
        print("UP: Greater DOWN: Smaller ENTER: Equal");
    }
    
    // Use this for initialization
    void Start () {
        StartGame(); 
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow pressed");
            min = guess;
            guess = (min + max) / 2;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow pressed");
            max = guess;
            guess = (min + max) / 2;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter pressed");
            print("Congratz you won the number was " + guess+"!");
        }

    }
}
