using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    public GameObject lightPrefab;

    float timer = 0;
    public float timerLength = 5;

    GameObject lightInstance;

    bool status = false;

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer += Time.deltaTime;
        }

        if (timer >= timerLength)
        {
            lightInstance = Instantiate(lightPrefab);
            timer = -1; 
        }
    }

    public void Power()
    {
        if (timer == -1)
        {
            if (status == false)
            {
                Debug.Log("On!");
                lightInstance.transform.localScale = Vector3.one * 1.4f;
                lightInstance.GetComponent<SpriteRenderer>().material.color = Color.yellow;
                status = true;
            }
            else
            {
                Debug.Log("Off!");
                lightInstance.transform.localScale = Vector3.one;
                lightInstance.GetComponent<SpriteRenderer>().material.color = Color.white;
                status = false;
            }
        }
    }
}
