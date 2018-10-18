using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int min = 1;
    int max = 1000;
    int guess = 500;
    int guessnumber = 0;

    void Start()
    {
        Debug.Log("Welcome!");
        Debug.Log("Pick number between: " + min + " and " + max);
        Debug.Log("Make sure u keep that number in secret.");
        Debug.Log("I'm going to guess that number!");
        Debug.Log("Tell me if number is higher or lower than: " + guess);
        Debug.Log("Use Up Arrow and Down Arrow to tell if its higher or lower.");
        Debug.Log("Press Enter if number is correct.");
        max = max + 1;
	}

    void Update()
    {
		if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than..." + guess);
            Debug.Log("Actual guess range varies between:" + min + " and " + max);
            guessnumber++;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than..." + guess);
            Debug.Log("Actual guess range varies between:" + min + " and " + max);
            guessnumber++;
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I guessed it in: " + guessnumber + " guesses!");
        }
    }
}
