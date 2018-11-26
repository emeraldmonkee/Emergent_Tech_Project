using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Spawner : MonoBehaviour
{
    public GameObject Key;

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
            Destroy(other);
        }
    }

    void Update()
    {
        if (ballCount == 2)
        {
            Key.SetActive(true);
        }
    }
}
