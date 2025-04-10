using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class LightControl : MonoBehaviour
{
    public Transform RedLight;
    public Transform GreenLight;

    public UnityEvent Stop;
    public UnityEvent Go;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Stop.Invoke();
        }
        if (Input.GetMouseButtonDown(1))
        {
            Go.Invoke();
        }
    }

   
}
