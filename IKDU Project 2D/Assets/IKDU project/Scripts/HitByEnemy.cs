using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HitByEnemy : MonoBehaviour
{
    public int damage;
    public PlayerHealth playerHealth; //takes the script on the player PlayerHealth
    float timer = 0;
    public float cooldown;
    bool hasAttacked = false;

    private void Update()
    {
        if (hasAttacked == true)
        {
            timer=timer+1*Time.deltaTime; // pluses one every time a second passes
        }

        if(timer >= cooldown) //checks if the curret time value has passed the cooldown time
        {
            hasAttacked = false;
            timer= 0;
        }
    }

    // Start is called before the first frame update
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
                     
            if (hasAttacked == false) //checks of the enemy has attacked
            {
                playerHealth.TakeDamage(10); //refrences playerHealth script
                hasAttacked= true; //sends it up to the start - starts the circle again.
            }
        }

    }

    //if (collision.transform.GetComponent<Attack>().isAttacking == true)
            
               // health -= 1;
            
}
