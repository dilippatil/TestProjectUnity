using UnityEngine;
using System.Collections;

[AddComponentMenu("Camera-Control/Mouse Orbit with zoom")]
public class objectRotate : MonoBehaviour
{



    float x = 0.0f;
    float y = 0.0f;
    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
    }

    void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            x -= Input.GetAxis("Mouse X");
            y -= Input.GetAxis("Mouse Y")/2;

            Quaternion rotation = Quaternion.Euler(y, x, 0);

            transform.rotation = rotation;
        }
        if (Input.GetKey("up"))
        {
            transform.Translate(0, 0, 0.05f);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(0, 0, -0.05f);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(-0.05f, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(0.05f, 0, 0);
        }
    }


}