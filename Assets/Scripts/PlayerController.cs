using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    // The player's attacks do not destroy the food as intended. I got stuck on a couple of parts and so didn't get to finish it all in the way I had hoped.


    // Variable to determine player speed
    public float speed = 3;

    // Obtaining references to the animator and sprite renderers on the knight character
    Animator animator;
    SpriteRenderer sr;

    bool playerStatus = false;

    // !! All coroutine related code has been commented out. I was planning to make it so the coroutine would allow the player to move when active, but would stop briefly if...
    // !! ... they were hit by a piece of food. When I tried running it for testing, it crashed my Unity, so I left it out as I wasn't able to fix it in time
    //Coroutine playerCanMove;
    //IEnumerator 

    void Start()
    {
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

       // playerCanMove = StartCoroutine(Healthy());
    }

    // Update is called once per frame
    void Update()
    {
        //if (playerStatus == true)
        //{
        // This line moves the player up and down with a horizontal axis input
            transform.position += new Vector3(0, Input.GetAxis("Vertical"), 0) * speed * Time.deltaTime;
       //}   
    }

    //private IEnumerator Healthy()
    //{
    //    while (true)
    //    {
    //        playerStatus = true;
    //    }
    //}

    // This function is called when the attack button is pressed. It causes the player to swing their sword, but I did not finish getting it to destroy the food
    public void attack()
    {
        animator.SetTrigger("attack");
    }
}
