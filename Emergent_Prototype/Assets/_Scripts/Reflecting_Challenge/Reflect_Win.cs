using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflect_Win : MonoBehaviour
{

    public GameObject Key;
    public GameObject stand;

    public int count;

    // Use this for initialization
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 2)
        {
            Key.SetActive(true);
            stand.SetActive(true);
        }
    }

    public void addcount()
    {
        count += 1;
    }


}
