using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown_Clock : MonoBehaviour
{
    private Text timerText;

    [SerializeField] private GameObject Gameover_UI;

    public float timeLeft;
    string mins;
    string seconds;

    public bool gameIsPlaying = false;

    private Game_Manager GM;

    void Awake ()
    {
        GM = GameObject.Find("Game_Manager").GetComponent<Game_Manager>();
        Gameover_UI = GameObject.Find("Gameover_UI");
	}

    void Start()
    {
        if(Gameover_UI.activeInHierarchy == true)
        {
            Gameover_UI.SetActive(false);
        }
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
        GM.CharacterDied();
        Gameover_UI.SetActive(true);
    }
}
