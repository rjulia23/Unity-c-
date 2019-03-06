using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NumberWizard : MonoBehaviour
{

    private int max = 100;
    private int min = 1;
    private int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NewGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NewGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("We got it!");
            StartGame();
        }
    }
    private void NewGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is your number " + guess);
    }
    private void StartGame()
    {
        System.Random rnd = new System.Random();
        min = rnd.Next(1, 100);
        max = rnd.Next(100, 1000); ;

        Debug.Log("Welcome!");
        Debug.Log("Pick a number from " + min + " to " + max);
        Debug.Log("Tell me if your number is higher(up), lower(down), or did I get it right(enter)?");
        NewGuess();
    }
}
