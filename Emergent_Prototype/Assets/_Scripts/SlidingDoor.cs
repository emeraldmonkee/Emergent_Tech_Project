using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoor : MonoBehaviour {

    public GameObject door;

    public Vector3 open;
    public Vector3 close;

    public Transform lockout;
    public Transform lockin;

    public bool moved;


	// Use this for initialization
	void Start () {

        //initializes the vectors for the doors  -Tom
        open = new Vector3(door.transform.position.x, door.transform.position.y + 4, door.transform.position.z);
        close = new Vector3(door.transform.position.x, door.transform.position.y, door.transform.position.z);
        moved = false;

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void opendoor()
    {
        StartCoroutine(lerp(door.transform,open,4));
    }

    //Lerps the position of the door to its new position  -Tom
    public IEnumerator lerp(Transform transform, Vector3 position, float timeToMove)
    {
        //Debug.Log("open seasume");
        yield return new WaitForSeconds(1);
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
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other);
        if(other.tag == ("Player"))
        {
            if (moved == false)
            {
                GetComponent<BoxCollider>().transform.position = lockin.transform.position;
                StartCoroutine(lerp(door.transform, close, 2));
                moved = true;
            }
            else if (moved == true)
            {
                GetComponent<BoxCollider>().transform.position = lockout.transform.position;
                StartCoroutine(lerp(door.transform, open, 2));
                moved = false;
            }
        }



    }
}
