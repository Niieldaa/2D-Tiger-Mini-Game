using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyfollow : MonoBehaviour
{
    public GameObject heroChar;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        heroChar = GameObject.FindGameObjectWithTag("Player");
        // this here finds the gameobject with the tag "player"
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movePos = (heroChar.transform.position - transform.position).normalized;
        transform.Translate(movePos*speed*Time.deltaTime);
        // this changes the position from the current position and distance between the player and enemy
    }
}
