﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame(){
        Debug.Log("Welcome to number wizard!");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number  you can pick is:" + max);
        Debug.Log("The lowest number you can pick is:" + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed.");
        }







    }
}
