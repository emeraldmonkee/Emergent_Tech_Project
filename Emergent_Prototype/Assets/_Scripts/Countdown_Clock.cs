using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown_Clock : MonoBehaviour
{
    private Text timerText;

    public float timeLeft;
    string mins;
    string seconds;

    public bool gameIsPlaying = false;

	void Start ()
    {
        timerText = GetComponent<Text>();
	}
	

	void Update ()
    {
        if (!gameIsPlaying)
        {
            return;
        }
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            mins = Mathf.Floor(((int)timeLeft % 3600) / 60).ToString("00");
            seconds = ((int)timeLeft % 60).ToString("00");
            timerText.text = mins + " : " + seconds;
        }
        else
        {
            gameIsPlaying = false;
            LoseCondition();
        }
	}

    void LoseCondition()
    {
        Debug.Log("You Died.");
    }
}
