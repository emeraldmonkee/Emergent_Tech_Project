using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour {

    public GameObject key;

    //public GameObject roomnode;

    //public GameObject doors;
    public GameObject[] slide;

    public SlidingDoor open;

    //public Transform[] points;

    public GameObject Clock;

    // Use this for initialization
    void Start () {

		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    //Instantiates new rooms at each of the exits and opens the doors 'SlidingDoor.cs' -Tom
    public void Activekey()
    {

        key.SetActive(true);
        //doors.SetActive(false);
        Clock.GetComponent<Countdown_Clock>().gameIsPlaying = false;
        //for (int i = 0; i < points.Length; i++)
        //{
        //    Instantiate(roomnode, points[i].transform.position, points[i].transform.rotation);
        //}

        for (int i = 0; i < slide.Length; i++)
        {
            open = slide[i].GetComponent<SlidingDoor>();
            open.keyon();
        }


    }


}
