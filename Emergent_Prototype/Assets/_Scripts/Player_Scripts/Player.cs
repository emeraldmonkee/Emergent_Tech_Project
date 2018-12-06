using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform look;
    public GameObject key;

    public Pillar pills;

    public bool haskey;

    public GameObject camrig;
    public GameObject cam;

    // Use this for initialization
    void Start ()
    {
        haskey = false;
    }


    // Update is called once per frame.
    void Update ()
    {

        camrig.transform.position = gameObject.transform.position - new Vector3(0, 0, 0);
        gameObject.transform.rotation = cam.transform.rotation;

        /*Fires a raycast infrount of the player  -Tom
          Detects keys and pillars*/

        if (Input.GetButtonDown("Fire1"))
        {

            float Distance = 2.5f;

            Ray ray = new Ray(look.position, look.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Distance))
            {
                //Debug.Log(hit.transform.gameObject);

                //Sets a key bool to true while showing a key in the players hand  -Tom
                if (hit.transform.gameObject.name == "keey" )
                {
                    Destroy(hit.transform.gameObject);
                    key.SetActive(true);
                    haskey = true;
                }

                //if play has the key, opens the doors 'Pillar.cs'  -Tom
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
