using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;

    public bool gameIsOver = false;

    public GameObject lastChallenge;

    private void Start()
    {
        lastChallenge = null;
    }

    public void PauseCharacter()
    {
        controller.characterIsPaused = true;
    }

    public void UnpauseCharacter()
    {
        controller.characterIsPaused = false;
    }

    public void CharacterDied()
    {
        gameIsOver = true;
        controller.characterIsPaused = true;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        Debug.Log(Cursor.lockState);
        Destroy(this);
    }
}
