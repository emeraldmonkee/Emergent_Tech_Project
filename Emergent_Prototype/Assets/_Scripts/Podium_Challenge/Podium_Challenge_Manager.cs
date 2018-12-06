using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Podium_Challenge_Manager : MonoBehaviour
{
    public GameObject Keey;
    public GameObject Podium;

    private int Podium_Cube;

    void Start()
    {
        Podium_Cube = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Podium_Cube")
        {
            Podium_Cube++;
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        if(Podium_Cube >= 8)
        {
            Keey.SetActive(true);
            Podium.SetActive(true);
        }
    }
}
