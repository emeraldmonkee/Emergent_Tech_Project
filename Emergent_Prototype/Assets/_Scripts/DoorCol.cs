using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCol : MonoBehaviour {

    public GameObject doorm;


    private void Start()
    {
        

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == ("Player"))
        {
            doorm.GetComponent<SlidingDoor>().opendoor();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == ("Player"))
        {
            doorm.GetComponent<SlidingDoor>().closedoor();
        }
    }
}
