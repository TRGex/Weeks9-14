using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CastleWall : MonoBehaviour
{
    // Allows for access of the Food Spawner script in order to reset its object locations and make use of its variables
    public FoodSpawner foodSpawner;

    // Obtains reference for the actual wall object in game
    public Transform castleWall;

    // Sets starting health of the wall (Number of hits it can take)
    public int wallHealth = 5;

    void Update()
    {
        // If a piece of food reaches the wall, it calls the wallHit function
        if (foodSpawner.foodStatus == true && foodSpawner.currentFood.transform.localPosition.x <= castleWall.position.x + 1)
        {
            wallHit();
        }
        // If the wall's health reaches zero, it stops the food from moving, effectively ending the game
        if (wallHealth == 0)
        {
            foodSpawner.speed = 0;
        }
    }

    // This function destroys the food that hit the wall and resets the process, allowing for a new piece to spawn
    void wallHit()
    {
        wallHealth--;
        Destroy(foodSpawner.currentFood);
        foodSpawner.foodStatus = false;
    }
}
