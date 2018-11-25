using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressure_Plate : MonoBehaviour
{
    public GameObject Clock;

    public GameObject challengeSpawner;

    public GameObject podem;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == ("Player"))
    //    {
    //        Clock.GetComponent<Countdown_Clock>().gameIsPlaying = true;
    //        this.transform.position -= new Vector3(0, 5, 0);
    //        Clock.GetComponent<Countdown_Clock>().timeLeft = 60;
    //        challengeSpawner.GetComponent<Challenge_Spawner>().SpawnChallenge();
    //    }
    //}

    private void Update()
    {
        if (this.transform.localPosition.y <= 1.07)
        {
            Clock.GetComponent<Countdown_Clock>().gameIsPlaying = true;
            podem.transform.position -= new Vector3(0f, 10f, 0f);
            this.transform.localPosition += new Vector3(0f, 0.07f, 0f);
            Clock.GetComponent<Countdown_Clock>().maxTime = 60;
            challengeSpawner.GetComponent<Challenge_Spawner>().SpawnChallenge();
        }
    }
}
