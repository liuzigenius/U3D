using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{

    // obj of camera to follow
    public Component follow;
    public float horizon_distance = 1.5f;
    public float vertical_distance = 1.5f;

    // Use this for initialization
    void Start()
    {
        if (follow != null)
        {
            //print("170 sin:" + GetSin(170));
            //print("270 cos:" + GetCos(270));

            this.transform.rotation = follow.transform.rotation;
            this.transform.position = follow.transform.position + new Vector3(horizon_distance * GetSin(this.transform.localEulerAngles.y), vertical_distance, -horizon_distance * GetCos(this.transform.localEulerAngles.y));
        }

    }

    private float GetSin(float angle)
    {
        float angle_360 = angle;
        while (angle_360 > 360)
        {
            angle_360 -= 360;
        }
        if (angle_360 >= 0 && angle_360 <= 180)
        {
            return Mathf.Sin(Mathf.PI * angle_360 / 180);
        }
        else
        {
            return -Mathf.Sin(Mathf.PI * (angle_360 - 180) / 180);
        }
    }

    private float GetCos(float angle)
    {
        float angle_360 = angle;
        while (angle_360 > 360)
        {
            angle_360 -= 360;
        }
        if (angle_360 >= 0 && angle_360 <= 180)
        {
            return Mathf.Cos(Mathf.PI * angle_360 / 180);
        }
        else
        {
            return -Mathf.Cos(Mathf.PI * (angle_360 - 180) / 180);
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (follow != null)
        {
            this.transform.rotation = follow.transform.rotation;
            print("y:" + transform.localEulerAngles.y);
            print("y hu:" + this.transform.rotation.y);
            print("sin" + this.transform.localEulerAngles.y + ":" + GetSin(this.transform.localEulerAngles.y));
            print("cos" + this.transform.localEulerAngles.y + ":" + GetCos(this.transform.localEulerAngles.y));
            this.transform.position = follow.transform.position + new Vector3(-horizon_distance * GetSin(this.transform.localEulerAngles.y), vertical_distance, -horizon_distance * GetCos(this.transform.localEulerAngles.y));
        }
    }
}
