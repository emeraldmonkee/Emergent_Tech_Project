using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Respawner : MonoBehaviour
{
    public GameObject gball, gball2, gkey;
    public GameObject ball1, ball2, key;

    private void Start()
    {
        ball1.transform.position = gball.transform.position;
        ball2.transform.position = gball2.transform.position;
        key.transform.position = gkey.transform.position;
        Debug.Log(key);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            if(other.gameObject.name == "GaryBall1")
            {
                other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                //other.gameObject.transform.localPosition = new Vector3(6.25f, 2.5f, 8f);
                other.gameObject.transform.position = ball1.transform.position;
            }
            else if(other.gameObject.name == "GaryBall2")
            {
                other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                //other.gameObject.transform.localPosition = new Vector3(7.75f, 2.5f, 6.5f);
                other.gameObject.transform.position = ball2.transform.position;
            }
        }
        if(other.gameObject.tag == "Keey")
        {
            Debug.Log("Key fell to the ground --> respawning");
            //other.gameObject.transform.position = new Vector3(-0.112f, 2.317f, 0);
            other.gameObject.transform.localPosition = key.transform.position;
        }
    }

}
