using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoor : MonoBehaviour {

    //This script handles opening the doors -Tom


    public GameObject door;
    public BoxCollider R;

    //The vectors values of the door being open and closed
    public Vector3 open;
    public Vector3 close;

    //Bool to store in what state the door is in open or closed
    public bool moved;


	void Start ()
    {
        //Initializes the open and close vectors for the doors
        open = new Vector3(door.transform.position.x, door.transform.position.y + 4, door.transform.position.z);
        close = new Vector3(door.transform.position.x, door.transform.position.y, door.transform.position.z);
        moved = false;
        R.enabled = false;

    }


    //When key is placed onto the platform
    public void keyon()
    {
        R.enabled = true;
        //StartCoroutine(Lerp(door.transform,open,4));
    }

    //Lerps the position of the door to its new position
    public IEnumerator Lerp(Transform transform, Vector3 position, float timeToMove)
    {
        //Debug.Log("open seasume");
        yield return new WaitForSeconds(0);
        var currentPos = transform.position;
        var t = 0f;
        while (t < 1)
        {
            t += Time.deltaTime / timeToMove;
            transform.position = Vector3.Lerp(currentPos, position, t);
            yield return null;
        }
    }

  //Detects when the player walks past a door, and reopens the door if the player somehow does not reach the new room before the door closes  -Tom
  public void opendoor()
    {
        if (moved == false)
        {
            
            StartCoroutine(Lerp(door.transform, open, 1));
            moved = true;
        }
    }

    public void closedoor()
    {
        if (moved == true)
        {
            
            StartCoroutine(Lerp(door.transform, close, 1));
            moved = false;
        }
    }

}
