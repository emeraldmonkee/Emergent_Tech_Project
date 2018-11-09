using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;

    //to check if the game is over
    public bool gameIsOver = false;

    //Last challenge spawned
    public GameObject lastChallenge;

    //The number of challenges completed
    public int challengesCompleted;

    private LevelCreation levelGenerator;

    private void Start()
    {
        levelGenerator = GameObject.Find("Generation").GetComponent<LevelCreation>();
        challengesCompleted = 0;
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

    public void ChallengeCompleted()
    {
        challengesCompleted++;

        if(challengesCompleted == levelGenerator.numberOfRooms)
        {
            WinCondition();
        }
    }

    private void WinCondition()
    {
        Debug.Log("YEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEET");
    }
}
