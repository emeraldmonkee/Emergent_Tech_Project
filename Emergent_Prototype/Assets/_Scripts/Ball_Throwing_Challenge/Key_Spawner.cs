using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Spawner : MonoBehaviour
{
    public GameObject Key;
    public GameObject Stand;

    private int ballCount;

    private void Start()
    {
        ballCount = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            ballCount++;
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        if (ballCount == 2)
        {
            Key.SetActive(true);
            Stand.SetActive(true);
        }
    }
}
