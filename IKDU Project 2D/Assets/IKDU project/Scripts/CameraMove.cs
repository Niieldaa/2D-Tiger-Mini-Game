using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject hero;
    public Camera MainCamera;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPos = hero.transform.position;             //Gets the players location 
        Camera.main.transform.position = new Vector3(playerPos.x, playerPos.y, Camera.main.transform.position.z);       //And then makes the camera follow this new location.
    }
}
