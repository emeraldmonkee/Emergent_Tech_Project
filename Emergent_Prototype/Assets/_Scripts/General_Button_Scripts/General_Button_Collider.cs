using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General_Button_Collider : MonoBehaviour {

    //Variables for UnknownMethod
    public GameObject Variables;

    public GameObject podem;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Button Pressed");
        if (other.gameObject.tag == "X")
        {
            UnknownMethod();
            podem.transform.position -= new Vector3(0f, 10f, 0f);
            other.gameObject.transform.position -= new Vector3(0f, 9f, 0f);
        }
    }

    private void UnknownMethod()
    {
        //Everything for the code goes here
    }
}
