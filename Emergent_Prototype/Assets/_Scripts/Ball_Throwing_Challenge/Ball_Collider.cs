using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Collider : MonoBehaviour
{
    public GameObject parentObject;

    public GameObject ballChallengeManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "YBall")
        {
            if(parentObject.name == "Ball_Yellow")
            {
                ballChallengeManager.GetComponent<Key_Spawner>().ballCount++;
                Destroy(other.gameObject);
            }
        }

        if (other.gameObject.tag == "RBall")
        {
            if (parentObject.name == "Ball_Red")
            {
                ballChallengeManager.GetComponent<Key_Spawner>().ballCount++;
                Destroy(other.gameObject);
            }
        }

        if (other.gameObject.tag == "BBall")
        {
            if (parentObject.name == "Ball_Blue")
            {
                ballChallengeManager.GetComponent<Key_Spawner>().ballCount++;
                Destroy(other.gameObject);
            }
        }
    }
}
