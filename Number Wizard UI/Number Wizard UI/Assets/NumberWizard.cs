using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI computerGuess;

    private int max = 1000;
    private int min = 1;
    private int guess;

    void Start(){
        StartGame();
    }

    private void NewGuess(){
        System.Random rnd = new System.Random();
        guess = rnd.Next(min, max);
        computerGuess.text = "Is your number " + guess + "?";
    }

    private void StartGame(){
        NewGuess();;
    }
    public void OnPressHigher(){
        min = guess + 1;
        NewGuess();
    }
    public void OnPressLower(){
        max = guess - 1;
        NewGuess();
    }
}
