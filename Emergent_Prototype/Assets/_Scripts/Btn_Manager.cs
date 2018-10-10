using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn_Manager : MonoBehaviour
{
    public void Start_Btn()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit_Btn()
    {
        Application.Quit();
    }

    public void Menu_Btn()
    {
        SceneManager.LoadScene(0);
    }

    public void Options_Btn()
    {
        SceneManager.LoadScene(2);
    }
}
