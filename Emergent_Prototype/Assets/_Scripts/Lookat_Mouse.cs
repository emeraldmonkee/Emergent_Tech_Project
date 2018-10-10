using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat_Mouse : MonoBehaviour
{
    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;

    GameObject character;

    public GameObject MainCanvas;

    void Start()
    {
        character = this.transform.parent.gameObject;
    }

    void Update()
    {
        if (Pause_Menu.gameIsPaused == true)
        {
            //This isn't working... Cri... plz help! <3
            return;
        }

        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;
        mouseLook.y = Mathf.Clamp(mouseLook.y, -45f, 45f);

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
    }
}
