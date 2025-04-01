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
        var position = new Vector3 (Random.Range(-8.0f, 9.0f), Random.Range(-4.0f, 6.0f), 0);
        Instantiate(moreBread, position, Quaternion.identity);
    }
}
