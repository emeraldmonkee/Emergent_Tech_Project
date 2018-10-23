using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooms {

    public Vector3 gridpos;

    public int type;

    public bool doorTop, doorBot, doorLeft, doorRight;

    public Rooms(Vector3 _gridpos, int _type)
    {
        gridpos = _gridpos;
        type = _type;
    }
}
