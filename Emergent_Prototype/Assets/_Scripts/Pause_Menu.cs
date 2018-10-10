using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Menu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenu;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
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

    void Resume()
    {
        Cursor.lockState = CursorLockMode.None;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        gameIsPaused = false;
    }

    void Pause()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }
}
