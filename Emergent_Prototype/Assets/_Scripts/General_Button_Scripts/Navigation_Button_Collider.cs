using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation_Button_Collider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Button Pressed");
        if (other.gameObject.tag == "Menu_Button")
        {
            Navigation_MainMenu();
        }
        else if (other.gameObject.tag == "Game_Button")
        {
            Navigation_MainGame();
        }
        else if (other.gameObject.tag == "Quit_Button")
        {
            Navigation_Quit();
        }
    }

    private void Navigation_MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void Navigation_MainGame()
    {
        SceneManager.LoadScene(1);
    }

    private void Navigation_Quit()
    {
        Application.Quit();
    }
}
