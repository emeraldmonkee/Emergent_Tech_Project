﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Menu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenu;
    public GameObject UI_Menu;

    private Game_Manager GM;

    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;

    void Start()
    {
        GM = GameObject.Find("Game_Manager").GetComponent<Game_Manager>();
        Cursor.lockState = CursorLockMode.Locked;   
        Cursor.visible = false;
    }

    void Update ()
    {
        if (GM.gameIsOver)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
	}

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        GM.UnpauseCharacter();
        pauseMenu.SetActive(false);
        UI_Menu.SetActive(true);
        Time.timeScale = 1;
        gameIsPaused = false;
    }

    void Pause()
    {
        Cursor.lockState = CursorLockMode.Confined;
        GM.PauseCharacter();
        UI_Menu.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }
}
