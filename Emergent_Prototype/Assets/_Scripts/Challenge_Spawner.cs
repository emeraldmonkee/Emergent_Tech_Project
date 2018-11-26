using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge_Spawner : MonoBehaviour
{
    public List<GameObject> _challenges;

    [SerializeField] private GameObject challengeToSpawn;

    private Game_Manager GM;

    void Start()
    {
        GM = GameObject.Find("Game_Manager").GetComponent<Game_Manager>();
    }

    public void SpawnChallenge()
    {
        challengeToSpawn = _challenges[Random.Range(0, _challenges.Count - 1)];
        if(GM.lastChallenge == null)
        {
            GM.lastChallenge = challengeToSpawn;
            SpawnChallenge();
        }
        else if (challengeToSpawn == GM.lastChallenge)
        {
            SpawnChallenge();
        }
        else if (challengeToSpawn != GM.lastChallenge)
        {
            GM.lastChallenge = challengeToSpawn;
            Instantiate(challengeToSpawn, this.transform.position, Quaternion.identity);
        }
    }
}
