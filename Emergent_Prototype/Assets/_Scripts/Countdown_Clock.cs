using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown_Clock : MonoBehaviour
{
    private Text timerText;

    private float timeLeft;
    string mins;
    string seconds;

	void Start ()
    {
        timerText = GetComponent<Text>();
        timeLeft = 120;
	}
	

	void Update ()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            mins = Mathf.Floor(((int)timeLeft % 3600) / 60).ToString("00");
            seconds = ((int)timeLeft % 60).ToString("00");
            timerText.text = mins + " : " + seconds;
        }
	}
}
