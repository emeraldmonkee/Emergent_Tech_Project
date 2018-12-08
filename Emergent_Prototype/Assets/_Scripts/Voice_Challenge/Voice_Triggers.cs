using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voice_Triggers : MonoBehaviour
{
    public GameObject parent;

    public GameObject Voice_Challenge_Manager;
    private Voice_Challenge_Manager VCM;

    private void Start()
    {
        VCM = Voice_Challenge_Manager.GetComponent<Voice_Challenge_Manager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (parent.gameObject.name == "Area1")
            {
                VCM.Area1Enter();
            }
            if (parent.gameObject.name == "Area2")
            {
                VCM.Area2Enter();
            }
            if (parent.gameObject.name == "Area3")
            {
                VCM.Area3Enter();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (parent.gameObject.name == "Area1")
            {
                VCM.Area1Exit();
            }
            if (parent.gameObject.name == "Area2")
            {
                VCM.Area2Exit();
            }
            if (parent.gameObject.name == "Area3")
            {
                VCM.Area3Exit();
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Coloured_Cube") 
        {
            if (parent.gameObject.name == "Area1")
            {
                VCM._area1Cube = other.gameObject;
            }
            if (parent.gameObject.name == "Area2")
            {
                VCM._area2Cube = other.gameObject;
            }
            if (parent.gameObject.name == "Area3")
            {
                VCM._area3Cube = other.gameObject;
            }
        }
    }
}
