using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public Animator animator;

    public float delay = 1f;

    public GameObject enemy;

    // private int pelletCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        animator.SetTrigger("Hurt");

        // Play hurt animation

        if (currentHealth <= 0)
        {
            Die(); // sends it down to the void
        }
    }

    void Die()
    {
        Debug.Log("Enemy died!");

        animator.SetBool("IsDead", true);

        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);

        //DestroyImmediate(gameObject, true);

        // GetComponent<Collider2D>().enabled = false;
        // this.enabled = false;                       // Disables the script

        // Code that didn't work or kinda?
        //GetComponent<Collider2D>().enabled = false;
        //this.enabled = false;
    }

    // void Count ()
    // {
        // if (DestroyObject.gameObject.tag == "Enemy")
     //    {
       //     pelletCount = pelletCount + 1;
     //    }
   // }


}