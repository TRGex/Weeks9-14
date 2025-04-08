using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ClockHands : MonoBehaviour
{
    public Transform minuteHand;
    public Transform hourHand;

    public UnityEvent HourTimer;

    float t = 0;

    public float hourLength = 6;
    float zRotation;

    void Update()
    {
        minuteHand.Rotate(0, 0, -(360 / hourLength) * Time.deltaTime);
        hourHand.Rotate(0,0, -(30 /  hourLength) * Time.deltaTime);

        t += Time.deltaTime;

        Debug.Log(t);

        zRotation = minuteHand.eulerAngles.z;

        if (t >= hourLength)
        {
            Debug.Log("Wahoo");
            HourTimer.Invoke();
            t = 0;
        }
    }
}
