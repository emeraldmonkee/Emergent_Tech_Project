using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour {

    public GameObject key;

    public GameObject doors;
    public GameObject[] slide;

    public SlidingDoor open;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Activekey()
    {
        key.SetActive(true);
        doors.SetActive(false);

        for (int i = 0; i < slide.Length; i++)
        {
            open = slide[i].GetComponent<SlidingDoor>();
            open.opendoor();
        }

    }
}
