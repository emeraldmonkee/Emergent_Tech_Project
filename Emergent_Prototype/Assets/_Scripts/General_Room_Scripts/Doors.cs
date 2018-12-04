using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour{

    private bool triggered = false;
    public GameObject connection;
    public GameObject Wall;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 4))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if (triggered == false)
            {
                triggered = true;

            }

        }
        else
        {
            triggered = true;
            Wall.SetActive(true);
            Destroy(connection);
        }

    }



}
