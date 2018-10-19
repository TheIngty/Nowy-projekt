using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int min;
    int max;
    int guess;
    int guesscount;

    void Start()
    {
        StartGame();
	}

    void StartGame()
    {
        guess = 500;
        min = 1;
        max = 1000;
        guesscount = 0;
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
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I guessed it in: " + guesscount + " guesses!");
            StartGame();
        }
    }
    
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
        guesscount++;
    }
}
