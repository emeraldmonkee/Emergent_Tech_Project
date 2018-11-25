using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown_Clock : MonoBehaviour
{
    private Text timerText;

    [SerializeField] private GameObject Gameover_UI;

    public float maxTime;
    public float timeLeft;
    string mins;
    string seconds;

    public bool gameIsPlaying = false;
    public bool timerIsSet = false;
    public bool glitchPlayed = false;

    private Game_Manager GM;

    private GlitchEffect glitchEffects;

    void Awake ()
    {
        GM = GameObject.Find("Game_Manager").GetComponent<Game_Manager>();
        Gameover_UI = GameObject.Find("Gameover_UI");
        glitchEffects = GameObject.Find("Camera").GetComponent<GlitchEffect>();
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

        if (!timerIsSet)
        {
            timeLeft = maxTime;
            timerIsSet = true;
        }

        //The following if statements state when a "glitch" should occur.

        // 75/100 of max time
        if ((int)timeLeft == (int)((maxTime / 100) * 75))
        {
            Glitch1();
        }

        // 50/100 of max time
        if ((int)timeLeft == (int)((maxTime / 100) * 50))
        {
            Glitch2();
        }

        // 40/100 of max time
        if ((int)timeLeft == (int)((maxTime / 100) * 40))
        {
            Glitch1();
        }
        // 39/100 of max time
        if ((int)timeLeft == (int)((maxTime / 100) * 39))
        {
            Glitch2();
        }

        // 25/100 of max time
        if ((int)timeLeft == (int)((maxTime / 100) * 25))
        {
            Glitch1and2();
        }

        // 10/100 of max time
        if ((int)timeLeft == (int)((maxTime / 100) * 10))
        {
            Glitch1and2();
        }
        // 9/100 of max time
        if ((int)timeLeft == (int)((maxTime / 100) * 9))
        {
            Glitch1();
        }

        // <3/100 of max time
        if ((int)timeLeft == (int)((maxTime / 100) * 3))
        {
            Glitch1and2();
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

    void Glitch1()
    {
        if (!glitchPlayed)
        {
            StartCoroutine(glitchEffects.Glitch1());
            glitchPlayed = true;
            StartCoroutine(PlayGlitch());
        }
    }

    void Glitch2()
    {
        if (!glitchPlayed)
        {
            StartCoroutine(glitchEffects.Glitch2());
            glitchPlayed = true;
            StartCoroutine(PlayGlitch());
        }
    }

    void Glitch1and2()
    {
        if (!glitchPlayed)
        {
            StartCoroutine(glitchEffects.Glitch1());
            StartCoroutine(glitchEffects.Glitch2());
            glitchPlayed = true;
            StartCoroutine(PlayGlitch());
        }
    }

    IEnumerator PlayGlitch()
    {
        yield return new WaitForSeconds(1);
        glitchPlayed = false;
    }
}
