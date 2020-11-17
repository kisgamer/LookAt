using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour
{

    public PlayerMovement movement;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movement.speed = 20f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movement.speed = 12f;
        }
    }
}
