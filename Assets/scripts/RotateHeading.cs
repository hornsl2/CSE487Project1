using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHeading : MonoBehaviour
{
    // Start is called before the first frame update

    public float sidewayspeed = 10.0f;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0.0f, -sidewayspeed * Time.deltaTime, 0.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0.0f, sidewayspeed * Time.deltaTime, 0.0f);
        }
    }
}
