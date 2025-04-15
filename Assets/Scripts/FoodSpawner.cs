using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    // Array of gameObjects allows for easy randomized selection
    public GameObject[] foodVariants;

    // GameObject that holds data for the current food
    public GameObject currentFood;

    // Boolean variable that tracks if food is currently in existence
    public bool foodStatus = false;

    // This variable manages the current speed of the food, and will be increased every time a point is scored
    public float speed = 5.0f;

    void Start()
    {

    }

    void Update()
    {
        // If there is currently no food, this if statement will spawn a new one and send it on its way
        if (foodStatus == false)
        {
            foodStatus = true;
            var spawnPosition = new Vector3(10, Random.Range(-3, 4), 0);
            // A random one of the food prefabs from the array is selected and instantiated off the right side of the screen at a random y location
            currentFood = Instantiate(foodVariants[Random.Range(0, 6)], spawnPosition, Quaternion.identity);
        }


        // Moves food to the left and rotates it for visual affect
        currentFood.transform.localPosition -= new Vector3 (speed * Time.deltaTime, 0, 0);
        currentFood.transform.Rotate(0, 0, 2.0f);

    }
}
