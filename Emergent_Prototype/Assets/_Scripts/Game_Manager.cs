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

    public GameObject Win_UI;

    public GameObject playerCharacter;


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

    public void ChallengeCompleted()
    {
        challengesCompleted++;

        if(challengesCompleted == levelGenerator.numberOfRooms)
        {
            WinCondition();
        }
    }

    public void WinCondition()
    {
        playerCharacter.transform.position = new Vector3(0, 25.4f, 0);
        Debug.Log("YEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEET");
    }

    public void LoseCondition()
    {
        gameIsOver = true;
        controller.characterIsPaused = true;
        playerCharacter.transform.position = new Vector3(0, 16.05f, 0);
        Debug.Log("u ded NIBBA");
    }
}
