using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Respawner : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Keey")
        {
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            other.transform.rotation = Quaternion.identity;
            other.transform.position = this.gameObject.transform.position + new Vector3(0, 2.5f, 0);
        }

        if (other.gameObject.tag == "YBall")
        {
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            other.transform.rotation = Quaternion.identity;
            other.transform.position = this.gameObject.transform.position + new Vector3(5.962f, 2.503f, 8.036f);
        }

        if (other.gameObject.tag == "RBall")
        {
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            other.transform.rotation = Quaternion.identity;
            other.transform.position = this.gameObject.transform.position + new Vector3(6.013f, 2.503f, 6.367f);
        }

        if (other.gameObject.tag == "BBall")
        {
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            other.transform.rotation = Quaternion.identity;
            other.transform.position = this.gameObject.transform.position + new Vector3(7.737f, 2.503f, 6.321f);
        }
    }
}
