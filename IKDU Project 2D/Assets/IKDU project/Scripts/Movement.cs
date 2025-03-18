using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
// THIS IS NOT WORKING THE SAME WAY AS THE PLAYERCONTROLLER SCRIPT :) 

        //UPDATE - THIS IS NOW NOTES FOR MYSELF
{
    public float speedBasic = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
}
