using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;
using System;

public class Voice_Challenge_Manager : MonoBehaviour
{
    private Voice_Recognizer voiceRczr;
    private bool inArea1;
    private bool inArea2;
    private bool inArea3;

    public Transform Area1CubeSpawn;
    public Transform Area2CubeSpawn;
    public Transform Area3CubeSpawn;

    public List<GameObject> Coloured_Cubes;

    private GameObject _lastCubeInstanciated;

    public GameObject _area1Cube;
    public GameObject _area2Cube;
    public GameObject _area3Cube;

    public int miniGameCounter;
    public GameObject keey;
    public GameObject podium;

    private void Awake()
    {
        voiceRczr = GameObject.Find("Recognizer_Manager").GetComponent<Voice_Recognizer>();
        voiceRczr.VCM = this;
        inArea1 = false;
        inArea2 = false;
        inArea3 = false;
    }
    void Start()
    {
        miniGameCounter = 0;

        Area1Instanciate();
        Area2Instanciate();
        Area3Instanciate();
    }

    void Update()
    {
        if (miniGameCounter == 3)
        {
            keey.SetActive(true);
            podium.SetActive(true);
            voiceRczr.VCM = null;
            Destroy(this);
        }
    }

    private void Area1Instanciate()
    {
         GameObject cubeToInstanciate = Coloured_Cubes[UnityEngine.Random.Range(0, Coloured_Cubes.Count)];
        if (_lastCubeInstanciated == null)
        {
            _lastCubeInstanciated = cubeToInstanciate;
            Area1Instanciate();
        }
        else if(cubeToInstanciate == _lastCubeInstanciated)
        {
            Area1Instanciate();
        }
        else if (cubeToInstanciate != _lastCubeInstanciated)
        {
            Instantiate(cubeToInstanciate, Area1CubeSpawn.position, Quaternion.identity);
        }
    }

    private void Area2Instanciate()
    {
        GameObject cubeToInstanciate = Coloured_Cubes[UnityEngine.Random.Range(0, Coloured_Cubes.Count)];

        if (cubeToInstanciate == _lastCubeInstanciated)
        {
            Area2Instanciate();
        }
        else if (cubeToInstanciate != _lastCubeInstanciated)
        {
            Instantiate(cubeToInstanciate, Area2CubeSpawn.position, Quaternion.identity);
        }
    }

    private void Area3Instanciate()
    {
        GameObject cubeToInstanciate = Coloured_Cubes[UnityEngine.Random.Range(0, Coloured_Cubes.Count)];

        if (cubeToInstanciate == _lastCubeInstanciated)
        {
            Area3Instanciate();
        }
        else if (cubeToInstanciate != _lastCubeInstanciated)
        {
            Instantiate(cubeToInstanciate, Area3CubeSpawn.position, Quaternion.identity);
        }
    }

    public void PinkRecognized()
    {
        if (inArea1 && _area1Cube.gameObject.name == "Pink_Cube(Clone)")
        {
            Debug.Log("You said Pink and was correct");
            Destroy(_area1Cube);
            miniGameCounter++;
        }
        else if (inArea2 && _area2Cube.gameObject.name == "Pink_Cube(Clone)")
        {
            Debug.Log("You said Pink and was correct");
            Destroy(_area2Cube);
            miniGameCounter++;
        }
        else if (inArea3 && _area3Cube.gameObject.name == "Pink_Cube(Clone)")
        {
            Debug.Log("You said Pink and was correct");
            Destroy(_area3Cube);
            miniGameCounter++;
        }
        else
        {
            Debug.Log("You said Pink and was incorrect");
        }
    }
    public void RedRecognized()
    {
        if (inArea1 && _area1Cube.gameObject.name == "Red_Cube(Clone)")
        {
            Debug.Log("You said Red and was correct");
            Destroy(_area1Cube);
            miniGameCounter++;
        }
        else if (inArea2 && _area2Cube.gameObject.name == "Red_Cube(Clone)")
        {
            Debug.Log("You said Red and was correct");
            Destroy(_area2Cube);
            miniGameCounter++;
        }
        else if (inArea3 && _area3Cube.gameObject.name == "Red_Cube(Clone)")
        {
            Debug.Log("You said Red and was correct");
            Destroy(_area3Cube);
            miniGameCounter++;
        }
        else
        {
            Debug.Log("You said Red and was incorrect");
        }
    }
    public void GreenRecognized()
    {
        if (inArea1 && _area1Cube.gameObject.name == "Green_Cube(Clone)")
        {
            Debug.Log("You said Green and was correct");
            Destroy(_area1Cube);
            miniGameCounter++;
        }
        else if (inArea2 && _area2Cube.gameObject.name == "Green_Cube(Clone)")
        {
            Debug.Log("You said Green and was correct");
            Destroy(_area2Cube);
            miniGameCounter++;
        }
        else if (inArea3 && _area3Cube.gameObject.name == "Green_Cube(Clone)")
        {
            Debug.Log("You said Green and was correct");
            Destroy(_area3Cube);
            miniGameCounter++;
        }
        else
        {
            Debug.Log("You said Green and was incorrect");
        }
    }
    public void BlackRecognized()
    {
        if (inArea1 && _area1Cube.gameObject.name == "Black_Cube(Clone)")
        {
            Debug.Log("You said Black and was correct");
            Destroy(_area1Cube);
            miniGameCounter++;
        }
        else if (inArea2 && _area2Cube.gameObject.name == "Black_Cube(Clone)")
        {
            Debug.Log("You said Black and was correct");
            Destroy(_area2Cube);
            miniGameCounter++;
        }
        else if (inArea3 && _area3Cube.gameObject.name == "Black_Cube(Clone)")
        {
            Debug.Log("You said Black and was correct");
            Destroy(_area3Cube);
            miniGameCounter++;
        }
        else
        {
            Debug.Log("You said Black and was incorrect");
        }
    }
    public void OrangeRecognized()
    {
        if (inArea1 && _area1Cube.gameObject.name == "Orange_Cube(Clone)")
        {
            Debug.Log("You said Orange and was correct");
            Destroy(_area1Cube);
            miniGameCounter++;
        }
        else if (inArea2 && _area2Cube.gameObject.name == "Orange_Cube(Clone)")
        {
            Debug.Log("You said Orange and was correct");
            Destroy(_area2Cube);
            miniGameCounter++;
        }
        else if (inArea3 && _area3Cube.gameObject.name == "Orange_Cube(Clone)")
        {
            Debug.Log("You said Orange and was correct");
            Destroy(_area3Cube);
            miniGameCounter++;
        }
        else
        {
            Debug.Log("You said Orange and was incorrect");
        }
    }
    public void YellowRecognized()
    {
        if (inArea1 && _area1Cube.gameObject.name == "Yellow_Cube(Clone)")
        {
            Debug.Log("You said Yellow and was correct");
            Destroy(_area1Cube);
            miniGameCounter++;
        }
        else if (inArea2 && _area2Cube.gameObject.name == "Yellow_Cube(Clone)")
        {
            Debug.Log("You said Yellow and was correct");
            Destroy(_area2Cube);
            miniGameCounter++;
        }
        else if (inArea3 && _area3Cube.gameObject.name == "Yellow_Cube(Clone)")
        {
            Debug.Log("You said Yellow and was correct");
            Destroy(_area3Cube);
            miniGameCounter++;
        }
        else
        {
            Debug.Log("You said Yellow and was incorrect");
        }
    }

    public void Area1Enter()
    {
        Debug.Log("Area 1 entered.");
        inArea1 = true;
    }
    public void Area1Exit()
    {
        Debug.Log("Area 1 exited.");
        inArea1 = false;
    }
    public void Area2Enter()
    {
        Debug.Log("Area 2 entered.");
        inArea2 = true;
    }
    public void Area2Exit()
    {
        Debug.Log("Area 2 exited.");
        inArea2 = false;
    }
    public void Area3Enter()
    {
        Debug.Log("Area 3 entered.");
        inArea3 = true;
    }
    public void Area3Exit()
    {
        Debug.Log("Area 3 exited.");
        inArea3 = false;
    }
}
