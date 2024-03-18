using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mancontroll : MonoBehaviour
{
    Animator animator;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();  // create a reference to our animator component
        spriteRenderer = GetComponent<SpriteRenderer>(); // create a reference to sprite renderer
    }

    // Update is called once per frame
    void Update()
    {
        //right arrow controls
        if (Input.GetKey(KeyCode.RightArrow))
        {

            animator.SetBool("right", Input.GetKey(KeyCode.RightArrow)); //set the right perameters true
            spriteRenderer.flipX = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("right", true); // set right perameter to false
            spriteRenderer.flipX = true;
        }
        else
        {
            animator.SetBool("right", false);
            spriteRenderer.flipX = false;
        }
        //up arrow controls
        if (Input.GetKey(KeyCode.UpArrow))
        {

            animator.SetBool("up", Input.GetKey(KeyCode.UpArrow)); //set the right perameters true
        }
        else
        {
            animator.SetBool("up", false); // set right perameter to false
        }
        //down arrow controls
        if (Input.GetKey(KeyCode.DownArrow))
        {

            animator.SetBool("down", Input.GetKey(KeyCode.DownArrow)); //set the right perameters true
        }
        else
        {
            animator.SetBool("down", false); // set right perameter to false
        }
    }
}
