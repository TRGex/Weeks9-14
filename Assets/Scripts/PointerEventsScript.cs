using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PointerEventsScript : MonoBehaviour
{
    public RectTransform bread;

    public GameObject moreBread;
    

    void Update()
    {
        
    }

    public void PointerEnter()
    {
        bread.localScale = Vector3.one * 1.2f;
    }

    public void PointerExit()
    {
        bread.localScale = Vector3.one;
    }

    public void PointerClick()
    {
       // Instantiate(moreBread,new Vector3(1,1,0));
    }
}
