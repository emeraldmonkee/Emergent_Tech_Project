using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    //Script to rotate keys on top of the pillar -Tom
	void Update ()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * 14);
    }
}
