using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform look;
    public GameObject key;

    public Pillar pills;

    public bool haskey;


    // Use this for initialization
    void Start ()
    {
        haskey = false;
    }


    // Update is called once per frame
    void Update ()
    {

        if (Input.GetButtonDown("Fire1"))
        {

            float Distance = 2.5f;

            Ray ray = new Ray(look.position, look.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Distance))
            {
                Debug.Log(hit.transform.gameObject);
                if (hit.transform.gameObject.name == "keey" )
                {
                    Destroy(hit.transform.gameObject);
                    key.SetActive(true);
                    haskey = true;
                }

                if (hit.transform.gameObject.name == "Pillar")
                {
                    if(haskey == true)
                    {
                        pills = hit.transform.gameObject.GetComponent<Pillar>();
                        key.SetActive(false);
                        haskey = false;
                        pills.Activekey();
                    }
                    else
                    {

                    }

                }

            }


        }

    }
}
