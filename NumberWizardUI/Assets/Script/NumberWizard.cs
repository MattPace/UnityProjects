using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int guess = 500;
    int maxNoGuess = 10;

    public Text Guess;

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(max,min);
        maxNoGuess--;
        Guess.text = guess.ToString();
        if(maxNoGuess == 0)
        {
            SceneManager.LoadScene("Win");
        }
    }

    void StartGame()
    {
        Debug.Log("Please choose a number in your head between " + min + " and " + max);
        print("Is the number greater or smaller than " + guess + " ?");
        print("UP: Greater DOWN: Smaller ENTER: Equal");
    }

    // Use this for initialization
    void Start()
    {
        StartGame();
    }
}
