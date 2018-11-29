using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Respawner : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            if(other.gameObject.name == "GaryBall1")
            {
                other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                other.gameObject.transform.localPosition = new Vector3(6.25f, 2.5f, 8f);
            }
            else if(other.gameObject.name == "GaryBall2")
            {
                other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                other.gameObject.transform.localPosition = new Vector3(7.75f, 2.5f, 6.5f);
            }
        }
    }

}
