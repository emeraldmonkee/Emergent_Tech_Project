using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation_Button_Collider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
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
        else if (other.gameObject.tag == "Practise_Button")
        {
            Navigation_Practice();
        }
        else if (other.gameObject.tag == "Game1_Button")
        {
            Navigation_Game1();
        }
        else if (other.gameObject.tag == "Game2_Button")
        {
            Navigation_Game2();
        }
        else if (other.gameObject.tag == "Game3_Button")
        {
            Navigation_Game3();
        }
        else if (other.gameObject.tag == "Game4_Button")
        {
            Navigation_Game4();
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

    private void Navigation_Practice()
    {
        SceneManager.LoadScene(2);
    }

    private void Navigation_Game1()
    {
        SceneManager.LoadScene(3);
    }

    private void Navigation_Game2()
    {
        SceneManager.LoadScene(4);
    }

    private void Navigation_Game3()
    {
        SceneManager.LoadScene(5);
    }

    private void Navigation_Game4()
    {
        SceneManager.LoadScene(6);
    }

    private void Navigation_Quit()
    {
        Application.Quit();
    }
}
