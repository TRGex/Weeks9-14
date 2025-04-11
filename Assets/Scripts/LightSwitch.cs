using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightSwitch : MonoBehaviour
{

    public UnityEvent Switch;

    void Update()
    {
       if (Input.GetKeyDown("space"))
        {
            Switch.Invoke();
        }
    }

}
