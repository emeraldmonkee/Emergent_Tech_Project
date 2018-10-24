using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressure_Plate : MonoBehaviour
{
    public GameObject Clock;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            Clock.GetComponent<Countdown_Clock>().gameIsPlaying = true;
            this.transform.position -= new Vector3(0, 1, 0);
            Clock.GetComponent<Countdown_Clock>().timeLeft = 120;
        }
    }
}
