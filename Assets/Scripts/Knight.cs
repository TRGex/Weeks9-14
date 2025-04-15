using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public float speed = 2;
    Animator animator;
    SpriteRenderer sr;

    public bool canRun = true;

    void Start()
    {
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        sr.flipX = direction < 0; //Basically an if statement

        animator.SetFloat("speed", Mathf.Abs(direction)); //Gives back size of number (no + or -)

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("attack");
            canRun = false;
        }

        if (canRun == true)
        {
            transform.position += transform.right * direction * speed * Time.deltaTime; //Makes the knight move
        }
    }

    public void AttackHasFinished()
    {
        Debug.Log("The attack just finished!");
        canRun = true;
    }
}
