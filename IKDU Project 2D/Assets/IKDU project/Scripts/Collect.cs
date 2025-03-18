using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour

{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        //(collision.gameObject.tag == "Collect")
        {
            ReactToPlayerCollision(); // this is a hevnvisning to the private void
        }
    }

    private void ReactToPlayerCollision()
    {
        Debug.Log("Item Collected!");
        Destroy(gameObject);
    }
}
