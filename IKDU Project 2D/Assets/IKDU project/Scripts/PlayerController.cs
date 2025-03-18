using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
// THIS IS NOT WORKING THE SAME WAY AS THE MOVEMENT SCRIPT :)
{
    public float moveSpeed = 0.1f;
    public Rigidbody2D rb;
    public Animator animator;
    public float speedBasic = 0.1f;

    Vector2 movement;
    //Vector2 stores an X & Y.

    public GameObject Collectible;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update() //update is called once per frame (not for physics, as the framerate can change)
    {
        //this was made for getting the imputs for the characters movement into the animator :))
      movement.x = Input.GetAxisRaw("Horizontal");
      movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.magnitude);

        //This under here is the character controls:

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speedBasic, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speedBasic, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, -speedBasic, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, speedBasic, 0f);
        }
    }
    void FixedUpdate() //Works the exact same way that update work, is called a bunch of times per second
                       //but on a fixed timer and not on the frame rate :)
    {
        // Makes the rigid body 2D move
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collect")
        {
            ReactToPlayerCollision(); // this is a hevnvisning to the private void
        }

        void ReactToPlayerCollision()
        {
            Debug.Log("Item Collected!");

            Destroy(collision.gameObject);
        }
       
    }
}
    
