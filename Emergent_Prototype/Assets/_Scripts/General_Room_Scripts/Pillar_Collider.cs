using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

public class Pillar_Collider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Keey")
        {
            Destroy(other.gameObject.GetComponent<InteractionBehaviour>());
            other.gameObject.transform.position -= new Vector3(0, 20, 0);
            this.GetComponentInParent<Pillar>().Activekey();
        }
    }
}
