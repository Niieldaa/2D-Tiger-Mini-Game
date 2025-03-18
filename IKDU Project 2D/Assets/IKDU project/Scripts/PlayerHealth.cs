using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject Hero;
    public int maxHealth = 100;
    public int health;

    //public TMP_Text healthText;
    
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;     // Makes the objects health 100 at the start of the game.
    }

    // Update is called once per frame
    void Update()
    {
       //healthText.text = "Health:" + health;
    }

    public void TakeDamage(int damage)
    {
        health -= damage; 
        if (health <=0) 
        {
            Destroy(Hero);
        } 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Collect")
        {
            health = health + 20;
        }
    }
}
