using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Car : MonoBehaviour
{
    public Transform carObject;

    public bool Going = true;

    public float speed = 1;

    void Update()
    {
        if (Going == true)
        {
            carObject.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (carObject.position.x > 7.85)
        {
            speed = -1;
        }

        if (carObject.position.x < -7.85)
        {
            speed = 1;
        }
    }

    public void Stop()
    {
        Going = false;
    }
    public void Go()
    {
        Going = true;
    }
}
