using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUpAndDown : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2.0f;
    public float upAngle=25.0f;
    public float downAngle=25.0f;
    // Update is called once per frame
    void Update()
    {

        float currentAngle = GetPlusMinusAngle(transform.localEulerAngles.x);


        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (currentAngle == -upAngle)
            {
            }
            else

              if (currentAngle - speed < -upAngle)
            {
                transform.Rotate(Vector3.left, (currentAngle + upAngle));
            }
            else { transform.Rotate(Vector3.left, speed); }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            {
                if (currentAngle == downAngle)
                {
                }
                else

                  if (currentAngle + speed > downAngle)
                {
                    transform.Rotate(Vector3.right, (downAngle - currentAngle));
                }
                else { transform.Rotate(Vector3.right, speed); }
            }
        }



    }
    float GetPlusMinusAngle(float angle)
    {
        if (angle > 180)
        {
            return angle - 360;
        }
        else
        {
            return angle;
        }
    }


}
