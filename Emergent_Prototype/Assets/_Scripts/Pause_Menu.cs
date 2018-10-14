using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Menu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenu;
    public GameObject UI_Menu;

    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;   
        Cursor.visible = false;
    }

    void Update ()
    {
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
        Cursor.visible = false;
        controller.gameIsPaused = false;
        pauseMenu.SetActive(false);
        UI_Menu.SetActive(true);
        Time.timeScale = 1;
        gameIsPaused = false;
    }

    void Pause()
    {
        Cursor.visible = true;
        controller.gameIsPaused = true;
        UI_Menu.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }
}
