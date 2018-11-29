using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar_Collider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Keey")
        {
            Destroy(other.gameObject);
            this.GetComponentInParent<Pillar>().Activekey();
        }
    }
}
