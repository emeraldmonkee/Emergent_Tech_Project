using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour {

    public GameObject key;

    //public GameObject roomnode;

    //public GameObject doors;
    public GameObject[] slide;

    private SlidingDoor open;

    //public Transform[] points;

    public GameObject Clock;

    private Game_Manager GM;

    // Use this for initialization
    void Start ()
    {
        GM = GameObject.Find("Game_Manager").GetComponent<Game_Manager>();

        open = null;
		
	}

    //Instantiates new rooms at each of the exits and opens the doors 'SlidingDoor.cs' -Tom
    public void Activekey()
    {

        key.SetActive(true);
        //doors.SetActive(false);
        Clock.GetComponent<Countdown_Clock>().gameIsPlaying = false;

        GM.ChallengeCompleted();
        //for (int i = 0; i < points.Length; i++)
        //{
        //    Instantiate(roomnode, points[i].transform.position, points[i].transform.rotation);
        //}

        for (int i = 0; i < slide.Length; i++)
        {
            if (slide[i] != null)
            {
                open = slide[i].GetComponent<SlidingDoor>();
                open.keyon();
            }
        }
    }
}
