using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge_Button_Collider : MonoBehaviour
{
    //Variables for Challenge spawer button
    public GameObject Clock;
    public GameObject challengeSpawner;

    public GameObject podem;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Challenge_Button")
        {
            ChallengeSpawner();
            podem.transform.position -= new Vector3(0f, 10f, 0f);
            other.gameObject.transform.position -= new Vector3(0f, 9f, 0f);
        }
    }

    void ChallengeSpawner()
    {
        
        challengeSpawner.GetComponent<Challenge_Spawner>().SpawnChallenge();
        Clock.GetComponent<Countdown_Clock>().gameIsPlaying = true;
        Clock.GetComponent<Countdown_Clock>().maxTime = 120;
    }
}
