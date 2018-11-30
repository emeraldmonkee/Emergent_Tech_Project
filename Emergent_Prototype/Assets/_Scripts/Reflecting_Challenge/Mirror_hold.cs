using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror_hold : MonoBehaviour {

    public GameObject mirror;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        mirror.transform.localPosition = this.gameObject.transform.localPosition + new Vector3(0,0.7f,0);
        mirror.transform.rotation = this.gameObject.transform.localRotation;
	}
}
