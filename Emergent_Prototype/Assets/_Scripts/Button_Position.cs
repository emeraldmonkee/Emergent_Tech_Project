using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Position : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if( this.gameObject.transform.localPosition.y >= 0.3f)
        {
            Debug.Log("ree");
            //this.gameObject.transform.localPosition -= new Vector3(0, 0.06f, 0);
        }
	}
}
