using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressure_Plate : MonoBehaviour
{
    public GameObject Clock;

    public GameObject challengeSpawner;

    public GameObject podem;

    //private void Update()
    //{

    //    if (this.transform.localPosition.y <= 1.07)
    //    {
    //        Clock.GetComponent<Countdown_Clock>().gameIsPlaying = true;
    //        podem.transform.position -= new Vector3(0f, 10f, 0f);
    //        this.transform.localPosition += new Vector3(0f, 0.01f, 0f);
    //        Clock.GetComponent<Countdown_Clock>().maxTime = 60;
    //        challengeSpawner.GetComponent<Challenge_Spawner>().SpawnChallenge();
    //        Debug.Log("Button Pressed");
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Challenge_Button")
        {
            Debug.Log("Button Pressed");
            challengeSpawner.GetComponent<Challenge_Spawner>().SpawnChallenge();
            Clock.GetComponent<Countdown_Clock>().maxTime = 60;
            Clock.GetComponent<Countdown_Clock>().gameIsPlaying = true;
            podem.transform.position -= new Vector3(0f, 10f, 0f);
            this.gameObject.isStatic = true;
        }
    }
}
