using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float playerSpeed = 0.05f;
     void Update()
    {
        move();
    }
    public void move()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y<4)
        {
            transform.position += new Vector3(0, playerSpeed, 0);
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y > -4)
        {
            transform.position += new Vector3(0, -playerSpeed, 0);
        }
    }
}
