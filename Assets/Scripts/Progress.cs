﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{

    public float timeRemaining = 240;
    public bool timerIsRunning = false;
    // public Text timeText;

    // private void Start()
    // {
        // timerIsRunning = true;
    // }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                // Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                GameManager.Instance.Final();
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        GameManager.Instance.TMPTextTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


}
